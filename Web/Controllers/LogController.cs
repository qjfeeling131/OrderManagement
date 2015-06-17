
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
    public class LogController : BaseController
    {
        //日记
        public ViewResult Index()
        {
            return View();
        }

        //留言板
        public ViewResult MessageBoard()
        {
            return View();
        }
   
    }
}
