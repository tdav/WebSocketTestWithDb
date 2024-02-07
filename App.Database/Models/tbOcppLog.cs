using System;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public class tbOcppLog
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn]
        [StringLength(100)]
        public string ChargePoint { get; set; }

        [StringLength(500)]
        public string Cmd { get; set; }
        public string InText { get; set; }
        public string OutText { get; set; }
        public bool IsError { get; set; }

        [IndexColumn]
        public DateTime CreateDate { get; set; }

        public string CodeCallerInfo { get; set; }
    }
}
