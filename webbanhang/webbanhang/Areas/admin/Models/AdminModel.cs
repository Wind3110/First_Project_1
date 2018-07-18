using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webbanhang.Areas.admin.Models
{
    public class AdminModel
    {
        [Display(Name = "Email Admin")]
        [Required(ErrorMessage = "Yêu cầu nhập Email.")]
        public string Email { get; set; }

        //[Display(Name = "Username")]
        //[Required(ErrorMessage = "Yêu cầu nhập username.")]
        //public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu.")]
        public string password { get; set; }
    }
}