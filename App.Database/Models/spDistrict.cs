using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.Models
{
    public class spDistrict : SpBaseModels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int RegionId { get; set; }
        public virtual spRegion Region { get; set; }
    }
}
