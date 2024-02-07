namespace App.Repository.Models
{
    public class viRemoteApiModel<T> where T : class
    {
        public string ChargePointId { get; set; }
        public string ConnectorId { get; set; }
        public T Data { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
