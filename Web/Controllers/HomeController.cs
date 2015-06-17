using OrderManager.Common;
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
using Web.UserService;
using OrderManager.Web.Models;



namespace OrderManager.Web
{
    public class HomeController : BaseController
    {

        private IUserService UserService;

        public HomeController()
        {
            UserService = new UserServiceClient();
        }


        public ViewResult Login()
        {
            return View();
        }


        public ViewResult Home()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Login(string UserCode, string Password, bool? IsRememeber)  //json 不能传null
        {
            //throw new Exception("aa");
            return Json(new JsonModel { Code = 1, Type = JsonTypeEnym.Redirect.ToString(), Data = Url.Content("~/home/home") });

            var pwd = Encryptor.MD5Encrypt(Password).ToUpper();
            var authority = UserService.Login(UserCode, pwd);

            if (IsRememeber == true)
                Session[UserCode] = string.Format("{0},{1}", UserCode, Password).GetHashCode();

            return Json(new JsonModel { Code = 1 ,Type="RedirectLocation"});
        }


        [HttpPost]
        public JsonResult SignOut()
        {     
            Session["User"] = null;
            return Json(new JsonModel { Code = 1, Type = JsonTypeEnym.Redirect.ToString(), Data = Url.Content("~/home/login") });
        }

    }
}
