using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spInternetAccessType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
