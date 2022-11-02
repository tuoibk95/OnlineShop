using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Utils
{
    [Serializable]
    public class UserSession
    {
        public string loginName { get; set; }
    }
}