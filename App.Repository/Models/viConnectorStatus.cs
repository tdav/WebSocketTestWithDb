namespace App.Repository.Models
{
    public class viConnectorStatus
    {
        public string ChargePointId { get; set; }

        public int ConnectorId { get; set; }

        public string ConnectorName { get; set; }

        public int? TransactionId { get; set; }
        public DateTime TransactionBegin { get; set; }

        public string LastStatus { get; set; }
        public DateTime? LastStatusTime { get; set; }

        public double? LastMeter { get; set; }
        public DateTime? LastMeterTime { get; set; }

        public Guid CreateUser { get; set; }
    }
}
