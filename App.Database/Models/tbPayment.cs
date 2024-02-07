using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    /// <summary>
    /// Тўловлар
    /// </summary>
    public class tbPayment : BaseModel
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Жами сумма
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Берилган Суммага қанча киловат
        /// </summary>
        public double BalanceKWatt { get; set; }

        /// <summary>
        /// Тўлов тури
        /// </summary>
        public int? PaymentTypeId { get; set; }
        public virtual spPaymentType PaymentType { get; set; }

        [IndexColumn(IsUnique = true)]
        public int OrderId { get; set; }

        public int PaymentStatusId { get; set; }
        public virtual spPaymentStatus PaymentStatus { get; set; }


        public new Guid CreateUser { get; set; }

        [ForeignKey("CreateUser")]
        public virtual tbUser tbUser { get; set; }


        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
