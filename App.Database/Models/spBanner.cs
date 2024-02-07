using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{

    public class spBanner : SpBaseModels
    {
        [Key]
        public int Id { get; set; }

        public string DpInfoUz { get; set; }
        public string DpInfoLt { get; set; }
        public string DpInfoRu { get; set; }
        public string DpInfoEn { get; set; }

        [StringLength(600)]
        public string ImgUrl { get; set; }

        [StringLength(300)]
        public string Slug { get; set; }
        public int Status { get; set; }
    }
}
