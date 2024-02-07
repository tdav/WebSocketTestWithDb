using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spCarModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
