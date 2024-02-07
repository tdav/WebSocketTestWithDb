namespace App.Repository.Models
{
    public class viDashboardRequest
    {
        public DateTime d1 { get; set; }
        public DateTime d2 { get; set; }
    }

    public class viLiveNetworkLoadPie
    {
        public int CurrentValue { get; set; }
        public int MaxValue { get; set; }
    }

    public class viLiveNetworkLoadHistory
    {
        public int Value { get; set; }
        public string ChargePoint { get; set; }
        public DateTime CreateDate { get; set; }

    }

    public class viChargePointConnectorStatus
    {
        public string ChargePoint { get; set; }
        public int ConnectorId { get; set; }
        public int ConnectorStatus { get; set; }
        public string ConnectorStatusName { get; set; }
    }


    public class viDashboardModel
    {
        public viLiveNetworkLoadPie LiveNetworkLoadPie { get; set; }
        public viLiveNetworkLoadHistory[] LiveNetworkLoadHistories { get; set; }
        public viChargePointConnectorStatus[] ChargePointConnectorStatuses { get; set; }

        public static viDashboardModel Create()
        {
            var rnd = new Random();
            var res = new viDashboardModel();

            res.LiveNetworkLoadPie = new viLiveNetworkLoadPie();
            res.LiveNetworkLoadPie.MaxValue = 10 * 56;
            res.LiveNetworkLoadPie.CurrentValue = 10 * 56 / 3;

            var ha = new List<viLiveNetworkLoadHistory>();
            var ca = new List<viChargePointConnectorStatus>();

            for (int i = 0; i < 10; i++)
            {
                var lh = new viLiveNetworkLoadHistory();
                lh.Value = rnd.Next(1, 56);
                lh.ChargePoint = $"TEST{i + 1}";
                lh.CreateDate = DateTime.Now.AddHours(-rnd.Next(1, 24));
                ha.Add(lh);

                var cs = new viChargePointConnectorStatus();
                cs.ChargePoint = lh.ChargePoint;
                cs.ConnectorId = 1;
                cs.ConnectorStatus = rnd.Next(1, 4);
                cs.ConnectorStatusName = GetStatus(cs.ConnectorStatus);
                ca.Add(cs);
            }

            res.LiveNetworkLoadHistories = ha.ToArray();
            res.ChargePointConnectorStatuses = ca.ToArray();

            return res;
        }

        private static string GetStatus(int i)
        {
            switch (i)
            {
                case 0: return "";
                case 1: return "Available";
                case 2: return "Occupied";
                case 3: return "Unavailable";
                case 4: return "Faulted";
                default: return "Not found";
            }
        }
    }
}
