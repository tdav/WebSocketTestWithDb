using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{

    public class viConnectorStatusView
    {
        [StringLength(100)]
        public string ChargePointId { get; set; }
        public int ConnectorId { get; set; }

        [StringLength(100)]
        public string ConnectorName { get; set; }

        [StringLength(100)]
        public string LastStatus { get; set; }
        public DateTime? LastStatusTime { get; set; }
        public double? LastMeter { get; set; }
        public DateTime? LastMeterTime { get; set; }
        public int? TransactionId { get; set; }

        [StringLength(50)]
        public string StartTagId { get; set; }
        public DateTime? StartTime { get; set; }
        public double? MeterStart { get; set; }

        [StringLength(100)]
        public string StartResult { get; set; }

        [StringLength(50)]
        public string StopTagId { get; set; }
        public DateTime? StopTime { get; set; }
        public double? MeterStop { get; set; }

        [StringLength(100)]
        public string StopReason { get; set; }
    }
}