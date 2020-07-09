using EasyDonthi.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EasyDonthi.Business
{
    public class UserManager
    {
        public bool ValidateUser(string username, string password)
        {
            UserDataProvider userDataProvider = new UserDataProvider();
            DataTable dt = userDataProvider.ValidateUser(username);
            foreach (DataRow dr in dt.Rows)
            {
                if(password == Convert.ToString(dr["Password"]))
                {
                    return true;
                }
            }
                return false;
        }

        public bool AddUser(string username, string password)
        {
            UserDataProvider userDataProvider = new UserDataProvider();
            DataTable dt = userDataProvider.ValidateUser(username);
            foreach (DataRow dr in dt.Rows)
            {
                if (password == Convert.ToString(dr["Password"]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
