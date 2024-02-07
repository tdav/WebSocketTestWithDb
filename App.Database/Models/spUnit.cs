using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.Models
{
    /// <summary>
    /// единица измерения
    /// </summary>
    public class spUnit : SpBaseModels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(10)]
        public string ShortName { get; set; }
    }
}
