using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public partial class tbChargeTag : BaseModel
    {
        [Key]
        [StringLength(50)]
        public string TagId { get; set; }

        [StringLength(200)]
        public string TagName { get; set; }

        [StringLength(50)]
        public string ParentTagId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? Blocked { get; set; }
    }
}
