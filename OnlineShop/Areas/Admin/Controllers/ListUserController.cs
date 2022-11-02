using Models;
using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class ListUserController : Controller
    {
        // GET: Admin/ListUser
        public ActionResult Index()
        {
            var iplUserInfo = new UserInfoViewModel();
            var model = iplUserInfo.ListAll();
            return View(model);
        }

        // GET: Admin/ListUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/ListUser/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ListUser/Create
        [HttpPost]
        public ActionResult Create(tbl_user collection)
        {
            try
            {
                var result = new UserInfoViewModel().CreateUser(collection.group_id, collection.login_name, collection.password, collection.full_name,collection.full_name_kana,collection.email,collection.tel, collection.birthday,collection.rules,collection.salt);
                // TODO: Add insert logic here
                if (result == 1 && ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("","Thêm mới không thành công");
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ListUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/ListUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ListUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/ListUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
