
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
    public class UserController : BaseController
    {

        public ViewResult Index()
        {
            return View();
        }
    }
}
