using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDonthi.Data
{
    public class UserDataProvider
    {
        private Database database;
        public const string GetUser = @"SELECT * FROM dbo.Users WITH (NOLOCK) WHERE Username = @UserName";
        public UserDataProvider()
        {
        }

        public DataTable ValidateUser(string userName)
        {
            DataSet ds = new DataSet();
            try
            {
                database = new DatabaseProviderFactory().CreateDefault();
                using (DbCommand spCommand = database.GetStoredProcCommand("ValidateU1ser"))
                {
                    database.AddInParameter(spCommand, "@UserName", DbType.String, userName);
                    ds = database.ExecuteDataSet(spCommand);
                    return (ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public DataTable AddUser(string userName)
        {
            DataSet ds = new DataSet();
            try
            {
                database = new DatabaseProviderFactory().CreateDefault();
                using (DbCommand spCommand = database.GetStoredProcCommand("AddUser"))
                {
                    database.AddInParameter(spCommand, "@UserName", DbType.String, userName);
                    ds = database.ExecuteDataSet(spCommand);
                    return (ds.Tables.Count > 0 ? ds.Tables[0] : new DataTable());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

    }
}
