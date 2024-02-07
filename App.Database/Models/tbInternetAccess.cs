using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    /// <summary>
    /// Доступ к интернету
    /// </summary>
    public partial class tbInternetAccess : BaseModel
    {
        [Key]
        public int Id { get; set; }


        public int ChargePointId { get; set; }
        public tbChargePoint ChargePoint { get; set; }

        public int InternetAccessTypeId { get; set; }
        public spInternetAccessType InternetAccessType { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public bool? Blocked { get; set; }


        [StringLength(100)]
        public string Comment { get; set; }
    }
}
