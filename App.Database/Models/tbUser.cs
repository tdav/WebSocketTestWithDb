using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class tbUser : IdentityUser<Guid>
    {
        [Key]
        public override Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Patronymic { get; set; }

        /// <summary>
        /// Фойдаланувчи балансидаги киловат
        /// </summary>
        public double BalanceSumma { get; set; }

        //[Required]
        //[StringLength(20)]
        //public override string PhoneNumber { get; set; }

        public bool Verified { get; set; }

        [StringLength(100)]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }


        [DefaultValue(1)]
        public int Status { get; set; }
        public Guid CreateUser { get; set; }
        public Guid? UpdateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual List<tbUserRole> UserRoles { get; }
    }
}
