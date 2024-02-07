using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace App.Server.Report.Services
{
    public class FileReportStorageWebExtension : ReportStorageWebExtension
    {
        readonly string ReportDirectory;
        const string FileExtension = ".repx";
        Dictionary<string, Func<XtraReport>> Reports;

        public FileReportStorageWebExtension(IWebHostEnvironment env)
        {
            ReportDirectory = Path.Combine(env.ContentRootPath, $"App_Data{Path.DirectorySeparatorChar}Reports");
            if (!Directory.Exists(ReportDirectory))
            {
                Directory.CreateDirectory(ReportDirectory);
            }

            LoadRepx(ReportDirectory, FileExtension);
        }

        public void LoadRepx(string path, string fileExtension)
        {
            Reports = new Dictionary<string, Func<XtraReport>>();

            var myFiles = Directory.EnumerateFiles(path, '*' + fileExtension, SearchOption.TopDirectoryOnly).ToArray();

            foreach (var it in myFiles)
            {
                var rn = Path.GetFileNameWithoutExtension(it);

                Reports.Add(rn.ToLower(), () => XtraReport.FromFile(it));
            }
        }

        public override bool CanSetData(string url)
        {
            return true;
        }

        public override bool IsValidUrl(string url)
        {
            return true;
        }

        public override byte[] GetData(string url)
        {
            try
            {
                if (Directory.EnumerateFiles(ReportDirectory).Select(Path.GetFileNameWithoutExtension).Contains(url))
                {
                    return File.ReadAllBytes(Path.Combine(ReportDirectory, url + FileExtension));
                }
                if (Reports.ContainsKey(url))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Reports[url]().SaveLayoutToXml(ms);
                        return ms.ToArray();
                    }
                }
                throw new DevExpress.XtraReports.Web.ClientControls.FaultException(string.Format("Could not find report '{0}'.", url));
            }
            catch (Exception)
            {
                throw new DevExpress.XtraReports.Web.ClientControls.FaultException(string.Format("Could not find report '{0}'.", url));
            }
        }

        public override Dictionary<string, string> GetUrls()
        {
            return Directory.GetFiles(ReportDirectory, "*" + FileExtension)
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .Concat(Reports.Select(x => x.Key))
                                     .ToDictionary(x => x);
        }

        public override void SetData(XtraReport report, string url)
        {
            report.SaveLayoutToXml(Path.Combine(ReportDirectory, url + FileExtension));
        }

        public override string SetNewData(XtraReport report, string defaultUrl)
        {
            SetData(report, defaultUrl);
            return defaultUrl;
        }
    }
}
