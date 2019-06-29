using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Models
{

    public class WebsiteInfo
    {
        public const string  SiteName="课程管理系统";
        private string p1;
        private string p2;

        public List<ActionLinks> ActionLinks { get; set; }

        public WebsiteInfo(string p1, string p2)
        {
            ActionLinks = new List<ActionLinks>{
              new ActionLinks{Name="主页",Contorller="Home",Action="Index"},
              new ActionLinks{Name="关于",Contorller="Home",Action="About"},
              new ActionLinks{Name="联系方式",Contorller="Home",Action="Contact"}
            };
        }

        public WebsiteInfo()
        {
            // TODO: Complete member initialization
        }

       
    }
}