using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spCarBrand : SpBaseModels
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int Status { get; set; }
    }
}
