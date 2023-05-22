﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShopSolution.ViewModel.System.Users
{
    public class UserVm
    {
        public Guid Id { get; set; }
        [Display(Name = "Hòm Thư")]
        public string Email { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [Display(Name = "Tên")]
        public string FirstName { get; set; }
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }
        [Display(Name = "Ngày Sinh")]
        public DateTime Dob { get; set; }

        public IList<string> Roles { get; set; } 

    }
}
