using System;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    /// <summary>
    /// Изменение цен
    /// </summary>
    public class tbPrice : BaseModel
    {
        [Key]
        public int Id { get; set; }

        public int Summa { get; set; }

        /// <summary>
        /// Шу санада боглаб 
        /// </summary>
        public DateTime ActivateDate { get; set; }

        public int ServiceTypeId { get; set; }
        public virtual spServiceType ServiceType { get; set; }
    }
}
