using App.Database;
using System.Net.WebSockets;
using System.Text;

namespace App.Server.Admin.Services
{
    public interface IDataAdapter
    {
        Task HandlerAsync(WebSocket webSocket, string Name);
    }

    public class DataAdapter : IDataAdapter
    {
        private readonly MyDbContext db;

        private readonly ILogger<DataAdapter> logger;

        public DataAdapter(MyDbContext db, ILogger<DataAdapter> logger)
        {
            this.db = db;
            this.logger = logger;
        }

        public async Task HandlerAsync(WebSocket webSocket, string Name)
        {
            while (webSocket.State == WebSocketState.Open)
            {
                string ocppRequest = await ReceiveAsync(webSocket);

                logger.LogTrace($"OCPPMiddleware.OCPP16 => ReceiveOcppMessage: {ocppRequest}");


                if (!string.IsNullOrWhiteSpace(ocppRequest))
                {
                }
            }

            logger.LogTrace($"Receive16 => Websocket closed: State={webSocket.State} / CloseStatus={webSocket.CloseStatus}");
        }


        private async ValueTask<string> ReceiveAsync(WebSocket socket)
        {
            string message = string.Empty;

            var buffer = WebSocket.CreateServerBuffer(8192);
            WebSocketReceiveResult result;

            using (var ms = new MemoryStream())
            {
                do
                {
                    result = await socket.ReceiveAsync(buffer, CancellationToken.None);

                    if (result.Count == 0)
                    {
                        break;
                    }

                    if (result != null && result.MessageType != WebSocketMessageType.Close)
                    {
                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                    }
                    else
                    {
                        logger.LogInformation($"OCPPMiddleware.Receive16 => WebSocket Closed: CloseStatus={result?.CloseStatus} / MessageType={result?.MessageType}");
                        await socket.CloseOutputAsync((WebSocketCloseStatus)3001, string.Empty, CancellationToken.None);
                    }

                } while (!result.EndOfMessage);

                if (ms.Length > 0)
                {
                    ms.Seek(0, SeekOrigin.Begin);

                    using (var reader = new StreamReader(ms, Encoding.UTF8))
                    {
                        message = await reader.ReadToEndAsync();
                    }
                }
            }

            return message;
        }
    }
}
