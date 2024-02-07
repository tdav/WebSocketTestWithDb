using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace App.Database.Models
{
    public partial class tbSystemSetting : BaseModel
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "jsonb")]
        public JsonDocument JsonData { get; set; }
    }
}
