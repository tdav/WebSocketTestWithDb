using System;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    /// <summary>
    /// Очередь водители
    /// </summary>
    public class tbQueueDriver : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public string PlateNumber { get; set; }

        [IndexColumn]
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }

        [StringLength(300)]
        public string UserInfo { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }


        [StringLength(100)]
        public string CancelReason { get; set; }


        [IndexColumn]
        public new Guid CreateUser { get; set; }

        [IndexColumn]
        public new int Status { get; set; }

        public int ConnectorId { get; set; }

        public int CarId { get; set; }
        public virtual tbCar Car { get; set; }

    }
}
