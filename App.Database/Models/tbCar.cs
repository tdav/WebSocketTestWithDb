using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    /// <summary>
    /// Авто
    /// </summary>
    public class tbCar : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(10)]
        public string PlateNumber { get; set; }

        [StringLength(50)]
        public string VinCode { get; set; }
        public int EVBatteryCapacity { get; set; }
        public double ChargingPerMinute { get; set; }

        public int? BrandId { get; set; }
        public virtual spCarBrand Brand { get; set; }

        public int? ModelId { get; set; }
        public virtual spCarModel Model { get; set; }

        public Guid DriverId { get; set; }
        public virtual tbUser Driver { get; set; }
    }
}
