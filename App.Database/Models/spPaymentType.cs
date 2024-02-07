using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.Models
{
    /// <summary>
    /// тип оплаты
    /// </summary>
    public class spPaymentType : SpBaseModels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    }
}
