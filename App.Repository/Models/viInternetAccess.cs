namespace App.Repository.Models
{
    public partial class viInternetAccess
    {
        public int Id { get; set; }

        public int ChargePointId { get; set; }
        public string ChargePoint { get; set; }

        public int InternetAccessTypeId { get; set; }
        public string InternetAccessType { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public bool? Blocked { get; set; }

        public string Comment { get; set; }

        public int Status { get; set; }
    }
}
