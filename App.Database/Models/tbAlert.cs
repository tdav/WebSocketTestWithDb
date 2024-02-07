using System;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public partial class tbAlert
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Приоритет - 1..9
        /// </summary>
        public int Priority { get; set; }

        [StringLength(100)]
        public string ChargePointId { get; set; }
        public int ConnectorId { get; set; }


        [Required]
        public string Name { get; set; }
        public string JsonData { get; set; }

        [IndexColumn]
        public DateTime CreateDate { get; set; }
    }
}
