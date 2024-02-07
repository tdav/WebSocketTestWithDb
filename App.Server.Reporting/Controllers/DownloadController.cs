using DevExpress.XtraReports.Web.ClientControls;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace App.Server.Report.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadController : Controller
    {
        private readonly IMemoryCache cache;

        public DownloadController(IMemoryCache cache)
        {
            this.cache = cache;
        }

        [Authorize(Roles = "Отчеты")]
        [HttpPost("{id}")]
        public IActionResult Download(string id)
        {
            if (cache.TryGetValue("EXPORT_REPORT" + id, out ExportedDocument value))
            {
                return File(value.Bytes, value.ContentType, value.FileName);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
