using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbanhang.Models;

namespace webbanhang.Controllers
{
    public class HomeController : Controller
    {
        laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            List<SANPHAM> list = db.SANPHAMs.Select(x => x).ToList();
            return View(list);
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details(String id)
        {
            ViewBag.Message = "Your app description page.";
            List<SANPHAM> list = (from sp in db.SANPHAMs where sp.maSP == id select sp).ToList(); // sua lai thanh cau truy van
            return View(list);
        }
        public ActionResult phanloai_sp(String madm)
        {
            ViewBag.Message = "Your app description page.";
            List<SANPHAM> list = (from dm in db.SANPHAMs where dm.maDM == madm select dm).ToList(); // sua lai thanh cau truy van
            return View(list);
        }
        public ActionResult phanloai_hangsx(String hangsx)
        {
            ViewBag.Message = "Your app description page.";
            List<SANPHAM> list = (from hang in db.SANPHAMs where hang.xuatsu== hangsx select hang).ToList(); // sua lai thanh cau truy van
            return View(list);
        }

    }
}
