namespace App.Repository.Models
{
    public class viChargePointSm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Landmark { get; set; }
        public List<viConnectorStatusExt> ConnectorStatus { get; set; }
    }

    public class viConnectorStatusExt
    {
        public int Id { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Оҳирги статусини юборилган вақти
        /// </summary>
        public DateTime? StatusTime { get; set; }

        public string Type { get; set; }
        public int TypeId { get; set; }

        /// <summary>
        /// Нечи киловатт бериши
        /// </summary>
        public int Throughput { get; set; }
        public string ImageUrl { get; set; }

        /// <summary>
        /// Станция хозирги бериляпган КВ/ч
        /// </summary>
        public double? ChargeRateKW { get; set; }

        /// <summary>
        /// Станциянинг охирги счетик кўрсаткичи
        /// </summary>
        public double? MeterKWH { get; set; }

        public double? EndMeterKWH { get; set; }

        /// <summary>
        /// Автомобил акумулятор заряди фоизда
        /// </summary>
        public double? Soc { get; set; }

        /// <summary>
        /// Ҳайдовчи ҳақида маълумот
        /// </summary>
        public string DriverInfo { get; set; }

        /// <summary>
        /// Оҳирги транзакция Id
        /// </summary>
        public int? TransactionId { get; set; }

        /// <summary>
        /// Оҳирги зарядлаш қачон бошланган
        /// </summary>
        public DateTime? TransactionBegin { get; set; }
        public DateTime? TransactionEnd { get; set; }

        public double? MeterStart { get; set; }
        public double? MeterStop { get; set; }

        public string StopReason { get; set; }
    }
}
