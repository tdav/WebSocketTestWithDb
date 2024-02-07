using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;

namespace App.Server.Report.Controllers
{
    [Authorize(Roles = "Отчеты")]
    public class DefaultDashboardController : DashboardController
    {
        public DefaultDashboardController(DashboardConfigurator configurator, IDataProtectionProvider dataProtectionProvider = null)
            : base(configurator, dataProtectionProvider) { }
    }
}