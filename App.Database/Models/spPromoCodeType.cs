using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{

    /// <summary>
    /// Промо код тури
    /// </summary>
    public class spPromoCodeType : SpBaseModels
    {

        [Key]
        public int Id { get; set; }
    }
}
