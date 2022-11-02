using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Utils
{
    public class Common
    {
        public string Validate(string loginName, string password)
        {
            string messageValidate = string.Empty;
            if (string.IsNullOrEmpty(loginName) && string.IsNullOrEmpty(password))
            {
                messageValidate = "Không được để trống tài khoản, mật khẩu";
            }
            else if (string.IsNullOrEmpty(loginName) || string.IsNullOrEmpty(password))
            {
                messageValidate = "Không được để trống tài khoản hoặc mật khẩu.";
            }
            return messageValidate;
        }
    }
}