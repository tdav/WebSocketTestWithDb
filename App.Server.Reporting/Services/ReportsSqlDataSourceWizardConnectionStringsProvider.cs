using App.Database;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Web;
using System.Collections.Generic;
using System.Linq;

namespace App.Server.Report.Services
{
    public class ReportsSqlDataSourceWizardConnectionStringsProvider : IDataSourceWizardConnectionStringsProvider
    {
        readonly MyDbContext reportDataContext;

        public ReportsSqlDataSourceWizardConnectionStringsProvider(MyDbContext reportDataContext)
        {
            this.reportDataContext = reportDataContext;
        }

        Dictionary<string, string> IDataSourceWizardConnectionStringsProvider.GetConnectionDescriptions()
        {
            return reportDataContext.rpSqlDataConnections.ToDictionary(x => x.Name, x => x.DisplayName);
        }

        DataConnectionParametersBase IDataSourceWizardConnectionStringsProvider.GetDataConnectionParameters(string name)
        {
            return null;
        }
    }
}