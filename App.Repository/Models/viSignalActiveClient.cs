namespace App.Repository.Models
{
    public class viSignalActiveClient
    {
        public bool IsOcppMessageSubscribe { get; set; } = false;
        public string ConnectionId { get; set; }
        public Guid UserId { get; set; }
    }
}
