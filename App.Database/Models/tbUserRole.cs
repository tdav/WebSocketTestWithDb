using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.Models
{
    public class tbUserRole : IdentityUserRole<Guid>
    {
        [ForeignKey("UserId")]
        public virtual tbUser User { get; set; }

        [ForeignKey("RoleId")]
        public virtual spRole Role { get; set; }
    }
}
