﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModel.System.Users
{
    public class RegisterRequest
    {
        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }

        [Display(Name = "Hòm Thư")]
        public string Email { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }

        [Display(Name = "Mật Khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = " Nhập Lại Mật Khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassWord { get; set; }

    }
}
