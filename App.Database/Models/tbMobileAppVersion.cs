using System.ComponentModel.DataAnnotations;

namespace App.Database.Models;

public class tbMobileAppVersion : BaseModel
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string CurrentVersion { get; set; }

    [StringLength(50)]
    public string AcceptableVersion { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    [AllowedValues("ALL", "IOS", "ANDROID", "HARMONYOS", "HYPEROS")]
    public string TypeOs { get; set; }
}
