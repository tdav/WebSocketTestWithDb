using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spServiceType : SpBaseModels
    {
        [Key]
        public int Id { get; set; }
    }
}
