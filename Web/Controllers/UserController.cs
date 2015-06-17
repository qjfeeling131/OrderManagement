
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
using OrderManager.Web.Models;
using OrderManager.Model.Models;



namespace OrderManager.Web
{
    public class UserController : BaseController
    {

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ChangePassword(string oldPwd, string newPwd, string userGuid)
        {
            return Json(new JsonModel { Code = 1, Type = "Reload", Data = null });
        }


        public ViewResult UserList()
        {
            List<OM_User> list = new List<OM_User>() { 
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true}, 
              new OM_User{ Name="rrere", Account="c001", Email="wwerewr@qq.com", Gender=true},
            };

            return View("~/views/user/userlist.cshtml", list);
        }
    }
}
