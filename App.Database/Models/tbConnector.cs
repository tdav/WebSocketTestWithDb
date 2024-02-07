using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public partial class tbConnector : BaseModel
    {
        [Key]
        public int Id { get; set; }

        public int ChargePointId { get; set; }
        public virtual tbChargePoint ChargePoint { get; set; }

        /// <summary>
        /// Коннектор номери
        /// </summary>
        public int ConnectorId { get; set; }

        public int ConnectorTypeId { get; set; }
        public virtual spConnectorType ConnectorType { get; set; }

        [IndexColumn]
        public new int Status { get; set; }

        /// <summary>
        /// Пропускная способность
        /// </summary>
        public int Throughput { get; set; }
    }
}
