using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webbanhang.Models;

namespace webbanhang.Controllers
{
    public class DanhmucController : Controller
    {
        //
        // GET: /Danhmuc/

        public ActionResult Index()
        {
            return View();
        }

        laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
        public ActionResult Danhmuc()
        {
            List<DANHMUC> list1 = db.DANHMUCs.Select(n => n).ToList();
            return PartialView(list1);
        }
        public ActionResult hangsx()
        {
            List<SANPHAM> list2 = db.SANPHAMs.Select(n => n).ToList();
            return PartialView(list2);
        }
       
    }
}
