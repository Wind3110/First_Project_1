using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webbanhang.Models;

namespace webbanhang.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
        //#region[Dangky]
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangky(DangkyFormModel model)
        {
            laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
            NGUOIDUNG ng = new NGUOIDUNG();
            ng.tenND = model.name;
            ng.username = model.Username;
            ng.MK = model.password;

            ng.email = model.Email;
            ng.DC = model.address;
            ng.SDT = model.SDT;


            if (ModelState.IsValid)
            {
                UserManager user_manager = new UserManager();
                if (!user_manager.CheckUsername(model.Username) && !user_manager.CheckEmail(model.Email))
                {
                    db.NGUOIDUNGs.Add(ng);
                    db.SaveChanges();
                    FormsAuthentication.RedirectFromLoginPage(model.Username, false);
                    //ModelState.AddModelError(string.Empty, "Đăng ký thành công.");
                    TempData["success"] = "ĐĂNG KÝ THÀNH CÔNG";
                    //ModelState.AddModelError(string.Empty, "Login success.");
                    return RedirectToAction("Dangky");
                    //return View("Dangky");

                }
                else
                {
                    if (user_manager.CheckUsername(model.Username) || user_manager.CheckEmail(model.Email))
                    {
                        ModelState.AddModelError("", "Tên đăng nhập hoặc Email đã tồn tại.");
                        return View(model);
                    }

                }
            }
            return View();



            //}
            //if (ModelState.IsValid)
            //{
            //    UserManager user_manager = new UserManager();
            //    if (user_manager.CheckUsername(model.username) && user_manager.CheckEmail(model.email))
            //    {

            //        FormsAuthentication.RedirectFromLoginPage(model.username, false);

            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Login Name or Email already taken.");
            //    }
            //}

        }

        public ActionResult SuccessRegister()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginFormModel u)
        {
            if (ModelState.IsValid)
            {
                using (laptrinhweb1Entities1 db = new laptrinhweb1Entities1())
                {
                    var v = db.NGUOIDUNGs.Where(a => a.email.Equals(u.Email) && a.MK.Equals(u.password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.maND.ToString();
                        Session["Logedname"] = v.tenND.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }


            }

            return View(u);
        }

        public ActionResult AfterLogin()
        {
            if (Session["LogedUserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult FailRegister()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["Logedname"] = null;
            return Redirect("/");
        }

    }
}



