using App.Server.Report.Models;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Server.Report.Controllers
{
    [Route("")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Roles = "־עקועû")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Error")]
        public IActionResult Error()
        {
            ErrorModel model = new ErrorModel();
            return View(model);
        }

        [Route("Dashboard/{reportName}")]
        public IActionResult DashboardViewer(string reportName)
        {
            var viewerModel = new CustomReportViewerModel()
            {
                ReportName = reportName
            };
            return View(viewerModel);
        }

        [Route("Report/{reportName}")]
        public IActionResult ReportViewer([FromServices] IWebDocumentViewerClientSideModelGenerator viewerModelGenerator, string reportName)
        {
            reportName = string.IsNullOrEmpty(reportName) ? "TestReport" : reportName;
            var viewerModel = new CustomReportViewerModel()
            {
                ReportName = reportName,
                ViewerModel = viewerModelGenerator.GetModel(reportName, "/DXXRDV")
            };
            return View(viewerModel);
        }
    }
}