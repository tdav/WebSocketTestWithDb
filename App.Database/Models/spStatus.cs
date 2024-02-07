using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spStatus : SpBaseModels
    {
        [Key]
        public int Id { get; set; }
    }
}
