namespace App.Repository.Models
{

    public class viConnector
    {
        public int Id { get; set; }
        public string ChargePoint { get; set; }
        public int ChargePointId { get; set; }
        public int ConnectorId { get; set; }
        public int ConnectorTypeId { get; set; }
        public string ConnectorType { get; set; }
        public string ConnectorImageUrl { get; set; }
        public int Status { get; set; }

        /// <summary>
        /// Пропускная способность
        /// </summary>
        public int Throughput { get; set; }
    }

    public class viConnectorExt
    {
        public int Id { get; set; }
        public string ChargePoint { get; set; }
        public int ChargePointId { get; set; }
        public int Status { get; set; }
        public viConnectorType ConnectorType { get; set; }
    }


    public class viConnectorSm2
    {
        public int Id { get; set; }
        public int ConnectorId { get; set; }
        public int ConnectorTypeId { get; set; }
        public int Throughput { get; set; }
        public int Status { get; set; }
    }


    public class viConnectorSimple
    {
        public int Id { get; set; }
        public int ConnectorId { get; set; }
        public int ConnectorTypeId { get; set; }
        public string ConnectorType { get; set; }
        public string ConnectorImageUrl { get; set; }

        public int Status { get; set; }

        public string Country { get; set; }
        public int Throughput { get; set; }

        public double? CurChargeRateKW { get; set; }
        public double? CurMeterKWH { get; set; }
        public double? CurSoC { get; set; }
    }
}
