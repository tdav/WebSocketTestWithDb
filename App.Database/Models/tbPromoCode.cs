using System;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    /// <summary>
    /// Промо-кода
    /// </summary>
    public class tbPromoCode : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        [IndexColumn]
        [StringLength(10)]
        public string Code { get; set; }

        public int Value { get; set; }

        public int PromoCodeTypeId { get; set; }
        public virtual spPromoCodeType PromoCodeType { get; set; }

        [IndexColumn]
        public DateTime BeginDate { get; set; }

        [IndexColumn]
        public DateTime EndDate { get; set; }

        [IndexColumn]
        public Guid? UserUsed { get; set; }
    }
}
