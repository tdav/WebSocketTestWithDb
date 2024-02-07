using App.Database.Models;

namespace App.Repository.Models
{
    public class viChargePointExt
    {
        public int Id { get; set; }
        public string ChargePointId { get; set; }
        public string Name { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string ClientCertThumb { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }

        public string Region { get; set; }
        public string District { get; set; }

        public string Street { get; set; }
        public string Landmark { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public List<viQueueDriver> QueueDrivers { get; set; }
        public List<viConnectorSimple> Connectors { get; set; }
        public tbInternetAccess InternetAccess { get; set; }
    }


}
