using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace App.Server.Report.Models
{
    public class CustomReportViewerModel
    {
        public WebDocumentViewerModel ViewerModel { get; set; }
        public string ReportName { get; set; }
        public string Token { get; set; }
    }
}
