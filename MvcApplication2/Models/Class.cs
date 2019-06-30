using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public partial class Class
    {
        public int Id { get; set; }
         [Reruired]
        [StringLength(20)]
        [Display(Name="用户账号")]

        public string Name { get; set; }
    }
}