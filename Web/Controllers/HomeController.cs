
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Caching;
using System.Web.Mvc;
using System.Xml;
using System.Net.NetworkInformation;
using System.Net;
using System.Web;



namespace OrderManager.Web
{
    public class HomeController : BaseController
    {
        public ViewResult Login()
        {
            return View();
        }


        public ViewResult Home()
        {
            return View();
        }


        [HttpPost]
        public RedirectResult Login(string UserCode, string Password, bool? IsRememeber)  //json 格式不能传null
        {
            var aa = IsRememeber.ToString();
            Session["User"] = string.Format("{0},{1}", UserCode, Password);
            return Redirect("~/home/home"); 
        }

        public RedirectResult SignOut()
        {
            //Cache.Remove("User");
            Session["User"] = null;
            return Redirect("~/home/login"); 
        }
   
    }
}
