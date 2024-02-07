using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spSmsStatus : SpBaseModels
    {
        [Key]
        public int Id { get; set; }
    }
}
