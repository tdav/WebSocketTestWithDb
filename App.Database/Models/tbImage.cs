using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    /// <summary>
    /// Image Storage
    /// </summary>
    public class tbImage : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string FileName { get; set; }

        //Файл ҳажми
        public int Size { get; set; }

        [StringLength(300)]
        public string FilePath { get; set; }
    }
}
