using App.Models;
using App.Repository.Extensions;
using App.Server.Report.Models;
using App.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace App.Server.Report.Services
{
    public interface IReportsInfoService
    {
        Answer<InfoModel[]> GetDashboardList();
        Answer<InfoModel[]> GetReportList();
    }

    public class ReportsInfoService : IReportsInfoService
    {
        private readonly IOcppHttpContextAccessorExtensions accessor;
        private readonly ILogger<ReportsInfoService> logger;
        private readonly string myPath;

        public ReportsInfoService(ILogger<ReportsInfoService> logger, IWebHostEnvironment hostingEnvironment, IOcppHttpContextAccessorExtensions accessor)
        {
            myPath = hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data").PhysicalPath;
            this.logger = logger;
            this.accessor = accessor;
        }

        public Answer<InfoModel[]> GetDashboardList()
        {
            try
            {
                var list = new List<InfoModel>();
                string[] files = Directory.GetFiles(myPath + Path.DirectorySeparatorChar + "Dashboards", "*.xml");
                foreach (var it in files)
                {
                    var xdoc = XDocument.Load(it);

                    var im = new InfoModel();
                    im.Title = xdoc.Element("Dashboard").Element("Title").Attribute("Text").Value;
                    im.Name = Path.GetFileNameWithoutExtension(it);
                    im.Type = "dia";
                    list.Add(im);
                }

                return new Answer<InfoModel[]>(true, "", list.ToArray());
            }
            catch (Exception ee)
            {
                logger.LogError($"InfoService.GetDashboardList Error:{ee.GetAllMessages()}");
                return new Answer<InfoModel[]>(false, ee.GetAllMessages(), null);
            }
        }

        public Answer<InfoModel[]> GetReportList()
        {
            try
            {
                var list = new List<InfoModel>();
                string[] files = Directory.GetFiles(myPath + Path.DirectorySeparatorChar + "Reports", "*.repx");
                foreach (var it in files)
                {
                    var xdoc = XDocument.Load(it);
                    var im = new InfoModel();
                    var displayText = xdoc.Element("XtraReportsLayoutSerializer").Attribute("DisplayName");
                    if (displayText != null && string.IsNullOrWhiteSpace(displayText.Value))
                        im.Title = displayText.Value;
                    else
                        im.Title = xdoc.Element("XtraReportsLayoutSerializer").Attribute("Name").Value;

                    im.Name = Path.GetFileNameWithoutExtension(it);
                    im.Type = "rep";
                    list.Add(im);
                }

                return new Answer<InfoModel[]>(true, "", list.ToArray());
            }
            catch (Exception ee)
            {
                logger.LogError($"InfoService.GetReportList Error:{ee.GetAllMessages()}");
                return new Answer<InfoModel[]>(false, ee.GetAllMessages(), null);
            }
        }
    }
}
