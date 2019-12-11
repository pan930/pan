﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        [Reruired]
        [StringLength(20)]
        [Display(Name="用户账号")]

        public string Account { get; set; }
        [Reruired]
        [StringLength(20)]
        [Display(Name = "用户名")]

         public string Name { get; set; }
        [Reruired]
        [StringLength(20)]
        [Display(Name="用户 密码")]

         public string Password{ get; set; }
      
    }


}