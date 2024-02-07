using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.Models
{
    /// <summary>
    /// Туловнинг холатлари
    /// </summary>
    public class spPaymentStatus : SpBaseModels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
