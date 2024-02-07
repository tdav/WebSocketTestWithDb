using App.Database.Enums;
using App.Database.Models;
using Newtonsoft.Json;
using System.Net.WebSockets;

namespace App.Repository.Models
{
    public partial class ChargePointStatus
    {
        private Dictionary<int, OnlineConnectorStatus> _onlineConnectors;

        public ChargePointStatus(tbChargePoint chargePoint)
        {
            KeyId = chargePoint.Id;
            Id = chargePoint.ChargePointId;
            Name = chargePoint.Name;

            foreach (var it in chargePoint.Connectors)
            {
                var cc = new OnlineConnectorStatus()
                {
                    Throughput = it.Throughput,
                    ConnectorTypeId = it.ConnectorTypeId,
                    CurUserId = null,
                    SoC = 0,
                    MeterKWH = 0,
                    ChargeRateKW = 0,
                    Status = ConnectorStatusEnum.Undefined,
                };

                OnlineConnectors.Add(it.ConnectorId, cc);
            }
        }

        public Dictionary<int, OnlineConnectorStatus> OnlineConnectors
        {
            get
            {
                if (_onlineConnectors == null)
                {
                    _onlineConnectors = new Dictionary<int, OnlineConnectorStatus>();
                }
                return _onlineConnectors;
            }
            set
            {
                _onlineConnectors = value;
            }
        }

        /// <summary>
        /// ForenKey
        /// </summary>
        public int KeyId { get; set; }

        public DateTime? HeartBeatDateTime { get; set; }


        /// <summary>
        /// ID of chargepoint
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("connectorId")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Name of chargepoint
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// OCPP protocol version
        /// </summary>
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// WebSocket for internal processing
        /// </summary>
        [JsonIgnore]
        public WebSocket WebSocket { get; set; }
    }

    /// <summary>
    /// Encapsulates details about online charge point connectors
    /// </summary>
    public class OnlineConnectorStatus
    {
        /// <summary>
        /// Status of charge connector
        /// </summary>
        public ConnectorStatusEnum Status { get; set; }

        /// <summary>
        /// Current charge rate in kW
        /// </summary>
        public double? ChargeRateKW { get; set; }

        /// <summary>
        /// Current meter value in kWh
        /// </summary>
        public double? MeterKWH { get; set; }

        /// <summary>
        /// StateOfCharges in percent
        /// </summary>
        public double? SoC { get; set; }

        public Guid? CurUserId { get; set; }

        public int ConnectorTypeId { get; set; }

        /// <summary>
        /// Пропускная способность
        /// </summary>
        public int Throughput { get; set; }
    }
}
