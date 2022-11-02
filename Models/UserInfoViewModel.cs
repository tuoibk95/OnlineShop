using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserInfoViewModel
    {
        private OnlineShopDbContext context = null;

        public UserInfoViewModel()
        {
            context = new OnlineShopDbContext();
        }

        public List<tbl_user> ListAll()
        {
            var list = context.Database.SqlQuery<tbl_user>("Sp_UserInfo_ListAll").ToList();
            return list;
        }
    }
}
