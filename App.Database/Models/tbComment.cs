using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class tbComment : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string MesText { get; set; }

        public int Rating { get; set; }

        public Guid UserId { get; set; }
        public virtual tbUser User { get; set; }

        public int Status { get; set; }
        public int ChargePointId { get; set; }
        public virtual tbChargePoint ChargePoint { get; set; }
    }
}
