﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models.ValidatableObjects
{
    public class LoginInput
    {
        [Required]
        [Display(Name = "用户账号")]
        public string Account { get; set; }
        [Required]
        [Display(Name = "用户密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}