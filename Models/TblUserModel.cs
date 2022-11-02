using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TblUserModel
    {
        private OnlineShopDbContext context = null;

        public TblUserModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string loginName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@login_name", loginName),
                new SqlParameter("@password", password)
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @login_name, @password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
