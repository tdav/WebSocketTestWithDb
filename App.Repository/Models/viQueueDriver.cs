namespace App.Repository.Models
{


    public class viQueueDriver
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string PlateNumber { get; set; }
        public Guid DriverUserId { get; set; }
        public string UserInfo { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Comment { get; set; }
        public int ChargePointId { get; set; }
    }

}
