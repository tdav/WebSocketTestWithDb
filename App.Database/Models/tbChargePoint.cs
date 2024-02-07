using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public partial class tbChargePoint : BaseModel
    {
        public tbChargePoint() { Transactions = new HashSet<tbTransaction>(); }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [IndexColumn(IsUnique = true)]
        public string ChargePointId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(100)]
        public string ClientCertThumb { get; set; }

        /// <summary>
        /// Latitude: 41.3171  (41° 19′ 1.56″ N)        
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude: 69.2494  (69° 14′ 57.84″ E)
        /// </summary>
        public double Longitude { get; set; }

        public int? RegionId { get; set; }
        public virtual spRegion Region { get; set; }

        public int? DistrictId { get; set; }
        public virtual spDistrict District { get; set; }


        [StringLength(500)]
        public string Street { get; set; }

        /// <summary>
        /// Мўлжал
        /// </summary>
        [StringLength(200)]
        public string Landmark { get; set; }

        [IndexColumn]
        public new int Status { get; set; }



        public virtual ICollection<tbQueueDriver> QueueDrivers { get; set; }

        public virtual ICollection<tbTransaction> Transactions { get; set; }

        public virtual ICollection<tbConnector> Connectors { get; set; }
    }
}
