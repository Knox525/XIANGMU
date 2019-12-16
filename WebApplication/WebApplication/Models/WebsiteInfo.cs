using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{



    public class WebsiteInfo
    {
        public const string SiteName = "课程管理系统";

        public List<ActionLink> ActionLinks { get; set; }

        public WebsiteInfo()
        {
            ActionLinks = new List<ActionLink>
            {
                new ActionLink{Name="主页",Controller="Index",Action="Home"},
                new ActionLink{Name="关于",Controller="About",Action="Home"},
                new ActionLink{Name="联系方式",Controller="Contact",Action="Home"},
            };
        }
    }
}