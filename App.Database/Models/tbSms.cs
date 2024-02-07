using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    /// <summary>
    /// Sms
    /// </summary>
    public class tbSms : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string MesText { get; set; }

        [IndexColumn]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [IndexColumn]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(50)]
        public string MessageId { get; set; }

        public int StatusId { get; set; }
        public virtual spSmsStatus Status { get; set; }

        /// <summary>
        /// Юборишдаги хатоси
        /// </summary>
        [StringLength(200)]
        public string SendError { get; set; }
    }
}
