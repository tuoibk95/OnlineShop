using Models;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Areas.Admin.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var messageValidate = new Common().Validate(model.loginName, model.password);
            if (!string.Empty.Equals(messageValidate))
            {
                ModelState.AddModelError("", messageValidate);
            }
            else
            {
                //var result = new TblUserModel().Login(model.loginName, model.password);
                var result = Membership.ValidateUser(model.loginName, model.password);
                if (result && ModelState.IsValid)
                {
                    // Không cần sử dụng session vì MVC đã có cơ chế cookie
                    //SessionHelper.SetSession(new UserSession() { loginName = model.loginName });
                    FormsAuthentication.SetAuthCookie(model.loginName, model.RememberMe);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}