using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace App.Database.Models
{
    public class tbMeterValue : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int ChargePointId { get; set; }
        public virtual tbChargePoint ChargePoint { get; set; }

        public int ConnectorId { get; set; }
        public int TransactionId { get; set; }


        public double Temperature { get; set; }
        public double CurAmper { get; set; }
        public double CurVoltage { get; set; }
        public double Soc { get; set; }
        public double KiloWatt { get; set; }
        public double KiloWattHour { get; set; }

        [Column(TypeName = "jsonb")]
        public JsonDocument Data { get; set; }
    }
}
