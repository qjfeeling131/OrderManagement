
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
    public class LoginController : BaseController
    {
        public ViewResult index()
        {
            return View();
        }

        public ViewResult Exception()
        {
            return View("~/Views/Template/Exception.cshtml");
        }


        [HttpPost]
        public JsonResult Login(string UserCode, string Password, bool? IsRememeber)  //json 格式不能传null
        {
            var aa = IsRememeber.ToString();
            Session["User"] = string.Format("{0},{1}", UserCode, Password);
            //SetCookie("User", email, DateTime.Now.AddDays(1));
            //Cache.Store("User", email + pwd);  //Randy.Memcached
 
            return Json("randy"); 
        }

        public JsonResult SignOut()
        {
            //Cache.Remove("User");
            Session["User"] = null;
            return Json("randy");
        }
   
    }
}
