namespace App.Models
{
    public class viQueueMessage
    {
        public string Cmd { get; set; }
        public string JData { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid CreateUser { get; set; }
        public bool IsError { get; set; }

        public static viQueueMessage Create(string s, string cmd, string userId, bool IsError = false)
        {
            var value = new viQueueMessage();
            value.JData = AnswerBasic.Create(IsError, s);
            value.CreateUser = Guid.Parse(userId);
            value.CreateDate = DateTime.Now;
            value.Cmd = cmd;
            value.IsError = IsError;

            return value;
        }
    }
}
