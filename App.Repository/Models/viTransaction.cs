namespace App.Repository.Models
{
    public class viTransaction
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public int ChargePointId { get; set; }
        public string ChargePointName { get; set; }
        public int ConnectorId { get; set; }
        public string StartTagId { get; set; }
        public DateTime StartTime { get; set; }
        public double MeterStart { get; set; }
        public string StartResult { get; set; }
        public string StopTagId { get; set; }
        public DateTime? StopTime { get; set; }
        public double? MeterStop { get; set; }
        public string StopReason { get; set; }
        public double? Amount { get; set; }
    }


    public partial class viTransactionCarInfo
    {
        public int Id { get; set; }
        public double MeterStart { get; set; }
        public double? MeterStop { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public string StartTagId { get; set; }
    }
}
