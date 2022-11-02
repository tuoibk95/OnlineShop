using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string loginName { get; set; }
        [Required]
        public string password { get; set; }
        public bool RememberMe { get; set; }

    }
}