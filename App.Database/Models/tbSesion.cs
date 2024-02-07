using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class tbSesion
    {
        [Key]
        public int Id { get; set; }

        public Guid UserId { get; set; }

        /// <summary>
        /// Фойдаланувчи тури
        /// </summary>
        [StringLength(500)]
        public string Roles { get; set; }

        [StringLength(50)]
        public string IpAdress { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string DeviceId { get; set; }

        [StringLength(100)]
        public string Сountry { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
