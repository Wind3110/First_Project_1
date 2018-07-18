using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webbanhang.Models
{
    public class UserManager
    {
        laptrinhweb1Entities1 db = new laptrinhweb1Entities1();
        public bool CheckUsername(string Username)
        {
            return db.NGUOIDUNGs.Count(x => x.username == Username) > 0;  // câu truy vấn;
        }
        public bool CheckEmail(string Email)
        {
            return db.NGUOIDUNGs.Count(x => x.email == Email) > 0;
        }
    }
}