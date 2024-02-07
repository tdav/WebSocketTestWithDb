using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace App.Database.Models
{
    public class BaseModel
    {
        [DefaultValue(1)]
        public int Status { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }

        [IndexColumn]
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }

    public class SpBaseModels : BaseModel
    {
        [StringLength(200)]
        public string NameUz { get; set; }

        [StringLength(200)]
        public string NameLt { get; set; }

        [StringLength(200)]
        public string NameRu { get; set; }

        [StringLength(200)]
        public string NameEn { get; set; }
    }
}