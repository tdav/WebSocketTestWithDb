using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    //https://www.enelxway.com/us/en/resources/blog/ev-charging-connector-types
    //https://www.evexpert.eu/eshop1/knowledge-center/connector-types-for-ev-charging-around-the-world
    //https://pod-point.com/guides/driver/ev-connector-types-speed
    public class spConnectorType : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string DpInfo { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        [StringLength(200)]
        public string Country { get; set; }

        [StringLength(2)]
        public string Type { get; set; }
    }
}
