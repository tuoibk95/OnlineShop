using Models;
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ListUser/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
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
