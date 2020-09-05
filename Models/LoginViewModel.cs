﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        [Required (ErrorMessage ="{0}必填")]
        [MaxLength(50)]
        [Display(Name ="帳號")]
        [JsonProperty]
        public string userName { get; set; }
        [Required(ErrorMessage = "{0}必填")]
        [StringLength(100,ErrorMessage ="{0} 長度至少必須為{2}個字元",MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        [JsonProperty]
        public string password { get; set; }
    }
}