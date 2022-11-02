using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int CreateUser(int groupId, string loginName, string password, string fullName, string fullNameKana, string email, string tel, DateTime birthday, int rules, string salt)
        {
            object[] sqlParams =
            {
                new SqlParameter("@group_id", groupId),
                new SqlParameter("@login_name", loginName),
                new SqlParameter("@password", password),
                new SqlParameter("@full_name", fullName),
                new SqlParameter("@full_name_kana", fullNameKana),
                new SqlParameter("@email", email),
                new SqlParameter("@tel", tel),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@rules", rules),
                new SqlParameter("@salt", salt)
            };
            int res = context.Database.ExecuteSqlCommand("Sp_TblUser_Create @group_id, @login_name, @password, @full_name, @full_name_kana, @email, @tel, @birthday, @rules, @salt", sqlParams);
            return res;
        }
    }
}
