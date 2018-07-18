using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbanhang.Models;
using System.Web.Security;
using webbanhang.Areas.admin.Models;

namespace webbanhang.Areas.admin.Controllers
{
    public class BackController : Controller
    {
        //
        // GET: /admin/Home/

        public ActionResult Index()
        {
            if (Session["Logedadname"] != null)
            {
                return View();
            }
            else
            {
                return View("fail_admin");
            }
        }

        public ActionResult fail_admin()
        {
            return View();
        }

        #region[Delete]
        public ActionResult Delete(string id)
        {
            if (Session["Logedadname"] != null)
            {
                laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
                SANPHAM sp = new SANPHAM();
                var mot = db.SANPHAMs.First(p => p.maSP == id);
                db.SANPHAMs.Remove(mot);
                db.SaveChanges();
                return RedirectToAction("quanlysanpham");
            }
            else
            {
                return View("fail_admin");
            }
        }

        public ActionResult Deletedanhmuc(string iddm)
        {
            if (Session["Logedadname"] != null)
            {
                laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
                DANHMUC dm = new DANHMUC();
                var hai = db.DANHMUCs.First(p => p.maDM == iddm);
                db.DANHMUCs.Remove(hai);
                db.SaveChanges();
                return RedirectToAction("quanlydanhmuc");
            }
            else
            {
                return View("fail_admin");
            }
        }

        #endregion

        public ActionResult adminlogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult adminlogin(AdminModel t)
        {
            if (ModelState.IsValid)
            {
                using (laptrinhweb1Entities1 db = new laptrinhweb1Entities1())
                {
                    var h = db.ADMINs.Where(a => a.emailad.Equals(t.Email) && a.mkad.Equals(t.password)).FirstOrDefault();
                    if (h != null)
                    {
                        Session["LogedadID"] = h.maad.ToString();
                        Session["Logedadname"] = h.tenad.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }
            ModelState.AddModelError("", "Email hoặc mật khẩu không đúng!!!");
            return View(t);
        }


     public ActionResult quanlysanpham()
        {
            if (Session["Logedadname"] != null)
            {
                laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
                List<SANPHAM> list = db.SANPHAMs.Select(x => x).ToList();
                return View(list);
            }
            else
            {
                return View("fail_admin");
            }

        }

        public ActionResult quanlydanhmuc()
        {
            if (Session["Logedadname"] != null)
            {
                laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
                List<DANHMUC> list = db.DANHMUCs.Select(x => x).ToList();
                return View(list);
            }
            else
            {
                return View("fail_admin");
            }

        }
    }
}
