using App.Models;
using App.Server.Report.Models;
using App.Server.Report.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Server.Report.Controllers
{
    [Authorize(Roles = "Отчеты")]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsInfoController : ControllerBase
    {
        private readonly IReportsInfoService service;
        public ReportsInfoController(IReportsInfoService service)
        {
            this.service = service;
        }

        [HttpGet("Dashboards")]
        public Answer<InfoModel[]> GetDashboardList()
        {
            return service.GetDashboardList();
        }

        [HttpGet("Reports")]
        public Answer<InfoModel[]> GetReportList()
        {
            return service.GetReportList();
        }
    }
}
