namespace App.Repository.Models
{

    public class sqAllConnectorStatus
    {
        public int id { get; set; }
        public int charge_point_id { get; set; }
        public string charge_point_name { get; set; }
        public int connector_id { get; set; }
        public string status { get; set; }
        public DateTime? status_time { get; set; }
        public string driverinfo { get; set; }
        public string phone_number { get; set; }
        public string type { get; set; }
        public int type_id { get; set; }
        public string image_url { get; set; }
        public float soc { get; set; }
        public float charge_rate_kw { get; set; }
        public float meter_kwh { get; set; }
        public DateTime meter_value_time { get; set; }
        public DateTime start_time { get; set; }
        public DateTime stop_time { get; set; }
        public float meter_start { get; set; }
        public float meter_stop { get; set; }
        public float amount { get; set; }
        public int throughput { get; set; }
        public string stop_reason { get; set; }
    }

}
