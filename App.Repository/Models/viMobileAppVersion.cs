using System.ComponentModel.DataAnnotations;

namespace App.Repository.Models;

public class viMobileAppVersion
{
    [StringLength(50)]
    public string CurrentVersion { get; set; }

    [StringLength(50)]
    public string AcceptableVersion { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }
    public string TypeOs { get; set; }
}
