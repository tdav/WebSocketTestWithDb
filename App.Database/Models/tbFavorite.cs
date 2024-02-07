using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class tbFavorite : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int ChargePointId { get; set; }
        public virtual tbChargePoint ChargePoint { get; set; }
    }
}
