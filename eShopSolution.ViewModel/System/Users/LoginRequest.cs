using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace eShopSolution.ViewModel.System.Users
{
    public class LoginRequest
    {
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
