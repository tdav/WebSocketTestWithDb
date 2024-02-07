namespace App.Repository.Models
{
    public class viSms
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Phone { get; set; }
        public int SendUserId { get; set; }
        public DateTime SendedDate { get; set; }
        public string SendError { get; set; }
        public string Code { get; set; }
        public string MessageId { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
    }


    public class SmsRequest
    {
        public string PhoneNumber { get; set; }
    }

    public class viSmsResponse
    {
        public string Phone { get; set; }
        public string Code { get; set; }
        public string DeviceId { get; set; }
    }
}
