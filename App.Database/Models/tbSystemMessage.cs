using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public class tbSystemMessage
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn]
        [StringLength(100)]
        public string ChargePoint { get; set; }
        public int? ConnectorId { get; set; }

        public int Direction { get; set; }

        [StringLength(200)]
        public string Message { get; set; }

        [StringLength(200)]
        public string Result { get; set; }

        [StringLength(100)]
        public string ErrorCode { get; set; }

        [Column(TypeName = "jsonb")]
        public JsonDocument Data { get; set; }

        [IndexColumn]
        public DateTime CreateDate { get; set; }

        public string CodeCallerInfo { get; set; }
    }
}
