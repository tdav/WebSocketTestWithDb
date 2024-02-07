using App.Database;
using App.Database.Models;
using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.Web;
using DevExpress.DataAccess.Wizard.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Server.Report.Services
{
    public class ReportsDataSourceWizardJsonDataConnectionStorage : IDataSourceWizardJsonConnectionStorage
    {
        protected MyDbContext DbContext { get; }

        public ReportsDataSourceWizardJsonDataConnectionStorage(MyDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<JsonDataConnectionDescription> GetConnections()
        {
            return DbContext.rpJsonDataConnections.ToList();
        }

        bool IJsonConnectionStorageService.CanSaveConnection { get { return DbContext.rpJsonDataConnections != null; } }
        bool IJsonConnectionStorageService.ContainsConnection(string connectionName)
        {
            return GetConnections().Any(x => x.Name == connectionName);
        }

        IEnumerable<JsonDataConnection> IJsonConnectionStorageService.GetConnections()
        {
            return GetConnections().Select(x => CreateJsonDataConnectionFromString(x));
        }

        JsonDataConnection IJsonDataConnectionProviderService.GetJsonDataConnection(string name)
        {
            var connection = GetConnections().FirstOrDefault(x => x.Name == name);
            if (connection == null)
                throw new InvalidOperationException();
            return CreateJsonDataConnectionFromString(connection);
        }

        void IJsonConnectionStorageService.SaveConnection(string connectionName, JsonDataConnection dataConnection, bool saveCredentials)
        {
            var connections = GetConnections();
            var connectionString = dataConnection.CreateConnectionString();
            foreach (var connection in connections)
            {
                if (connection.Name == connectionName)
                {
                    connection.ConnectionString = connectionString;
                    DbContext.SaveChanges();
                    return;
                }
            }
            DbContext.rpJsonDataConnections.Add(new JsonDataConnectionDescription() { Name = connectionName, ConnectionString = connectionString });
            DbContext.SaveChanges();
        }

        public static JsonDataConnection CreateJsonDataConnectionFromString(DataConnection dataConnection)
        {
            return new JsonDataConnection(dataConnection.ConnectionString) { StoreConnectionNameOnly = true, Name = dataConnection.Name };
        }
    }
}