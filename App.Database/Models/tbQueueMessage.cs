using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public class tbQueueMessage
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "jsonb")]
        public string JData { get; set; }

        [IndexColumn]
        public DateTime CreateDate { get; set; }
        public Guid CreateUser { get; set; }

        [IndexColumn]
        public bool Status { get; set; }

        [IndexColumn]
        [StringLength(3)]
        public string Direction { get; set; }

        [StringLength(50)]
        public string Cmd { get; set; }

        [DefaultValue(false)]
        public bool IsError { get; set; }
    }
}
