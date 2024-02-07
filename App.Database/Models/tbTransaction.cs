using System;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public partial class tbTransaction
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Uid { get; set; }

        [Required]
        [IndexColumn]
        [StringLength(100)]
        public string ChargePointName { get; set; }

        [IndexColumn]
        public int ConnectorId { get; set; }
        public int ChargePointId { get; set; }
        public virtual tbChargePoint ChargePoint { get; set; }

        [StringLength(50)]
        public string StartTagId { get; set; }

        [IndexColumn]
        public DateTime StartTime { get; set; }
        public double MeterStart { get; set; }

        [StringLength(100)]
        public string StartResult { get; set; }

        [StringLength(50)]
        public string StopTagId { get; set; }

        [IndexColumn]
        public DateTime? StopTime { get; set; }
        public double? MeterStop { get; set; }

        [StringLength(100)]
        public string StopReason { get; set; }

        [IndexColumn]
        public Guid CreateUser { get; set; }

        public double? Amount { get; set; }

        public int? PromoCodeId { get; set; }
    }
}
