using App.Database;
using App.Repository.Models;
using App.Utils;
using System.Net;
using System.Net.WebSockets;

namespace App.Server.Admin.Services
{
    public class WebSocketMiddleware
    {
        public const string Protocol_OCPP16 = "ocpp1.6";
        public const string Protocol_OCPP20 = "ocpp2.0";
        public static readonly string[] SupportedProtocols = { Protocol_OCPP16, Protocol_OCPP20 };


        private static Dictionary<string, ChargePointStatus> _chargePointStatusDict;
        public static Dictionary<string, ChargePointStatus> ChargePointStatusDict
        {
            get
            {
                if (_chargePointStatusDict == null)
                {
                    _chargePointStatusDict = new Dictionary<string, ChargePointStatus>();
                    return _chargePointStatusDict;
                }
                else
                {
                    return _chargePointStatusDict;
                }
            }
        }


        private readonly RequestDelegate next;

        public WebSocketMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<WebSocketMiddleware> logger, IDataAdapter dataAdapter)
        {
            var chargepointIdentifier = context.Request.Path.Value.Split('/').LastOrDefault();

            var chargePointStatus = new ChargePointStatus(chargepointIdentifier);

            if (context.WebSockets.IsWebSocketRequest && context.Request.Path.StartsWithSegments("/ws_db"))
            {
                string subProtocol = null;
                foreach (string supportedProtocol in SupportedProtocols)
                {
                    if (context.WebSockets.WebSocketRequestedProtocols.Contains(supportedProtocol))
                    {
                        subProtocol = supportedProtocol;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(subProtocol))
                {
                    string protocols = string.Empty;
                    foreach (string p in context.WebSockets.WebSocketRequestedProtocols)
                    {
                        if (string.IsNullOrEmpty(protocols)) protocols += ",";
                        protocols += p;
                    }

                    logger.LogWarning($"OCPPMiddleware => No supported sub-protocol in '{protocols}' from charge station");
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
                else
                {
                    chargePointStatus.Protocol = subProtocol;
                    bool statusSuccess = false;

                    try
                    {
                        logger.LogTrace("OCPPMiddleware => Store/Update status object");

                        lock (ChargePointStatusDict)
                        {
                            if (ChargePointStatusDict.ContainsKey(chargepointIdentifier))
                            {
                                if (ChargePointStatusDict[chargepointIdentifier].WebSocket.State != WebSocketState.Open)
                                {
                                    ChargePointStatusDict.Remove(chargepointIdentifier);
                                }

                                ChargePointStatusDict[chargepointIdentifier] = chargePointStatus;
                            }

                            ChargePointStatusDict.Add(chargepointIdentifier, chargePointStatus);
                            statusSuccess = true;
                        }

                    }
                    catch (Exception exp)
                    {
                        logger.LogError($"OCPPMiddleware => SysConstants.ChargePointStatusDict Error:{exp.GetAllMessages()} Stack:{exp.GetStackTrace(5)}");
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    }


                    if (statusSuccess)
                    {
                        using (WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync(subProtocol))
                        {
                            logger.LogTrace($"OCPPMiddleware => WebSocket connection with charge point '{chargepointIdentifier}'");
                            chargePointStatus.WebSocket = webSocket;
                            var socketFinishedTcs = new TaskCompletionSource<string>();

                            await dataAdapter.HandlerAsync(webSocket, chargepointIdentifier);

                            await socketFinishedTcs.Task;
                        }
                    }

                }
            }
            else if (context.Request.Path.StartsWithSegments("/API"))
            {
                await next.Invoke(context);
            }
        }



    }

}
