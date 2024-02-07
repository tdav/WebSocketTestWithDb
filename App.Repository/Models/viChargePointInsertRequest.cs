namespace App.Repository.Models
{

    public class viChargePointInsertRequest
    {
        public int? Id { get; set; }
        public string ChargePointId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClientCertThumb { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        public string Street { get; set; }
        public string Landmark { get; set; }
        public int? Status { get; set; }
        public viConnectorSm[] Connectors { get; set; }
        public viInternetAccessRequest InternetAccess { get; set; }
    }

    public class viConnectorSm
    {
        public int ConnectorId { get; set; }
        public int ConnectorTypeId { get; set; }
        public int Throughput { get; set; }
        public int? Status { get; set; }
    }


    public class viInternetAccessRequest
    {
        public int InternetAccessTypeId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Blocked { get; set; }
        public string Comment { get; set; }
    }
}
