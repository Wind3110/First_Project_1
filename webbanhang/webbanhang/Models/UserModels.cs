using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webbanhang.Models
{
    public class LoginFormModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập Email.")]
        public string Email { get; set; }

        //[Display(Name = "Username")]
        //[Required(ErrorMessage = "Yêu cầu nhập username.")]
        //public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu.")]
        public string password { get; set; }
    }
    public class DangkyFormModel
    {   
        [Display(Name="Tên đăng nhập")]
        [Required(ErrorMessage= "Yêu cầu nhập tên đăng nhập.")]
        public string Username { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20,MinimumLength = 4, ErrorMessage= "Độ dài mật khẩu ít nhất 4 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu.")]
        public string password { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("password", ErrorMessage = "Xác nhận mật khẩu không khớp.")]
        public string confirmpassword { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên.")]
        public string name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập Email.")]
        public string Email { get; set; }

        [Display(Name = "Địa chỉ")]
        public string address { get; set; }
        //public int ID { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }

    }
}