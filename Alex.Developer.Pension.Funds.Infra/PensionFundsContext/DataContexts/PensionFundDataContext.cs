using Alex.Developer.Pension.Funds.Shared.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Alex.Developer.Pension.Funds.Infra.PensionFundsContext.DataContexts
{
    public class PensionFundDataContext : IDisposable
    {
        public SqlConnection Connection { get; set; }
        public PensionFundDataContext()
        {
            Connection = new SqlConnection(SettingConnection.connectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
