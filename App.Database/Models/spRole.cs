using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Database.Models
{
    public class spRole : IdentityRole<Guid>
    {
        [Key]
        public override Guid Id { get; set; }
        public virtual List<tbUser> Users { get; set; }
        public virtual List<tbUserRole> UserRoles { get; }
    }
}
