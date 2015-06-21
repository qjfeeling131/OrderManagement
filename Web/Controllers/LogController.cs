
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
using OrderManager.Model.Models;
using Web.UserService;
using OrderManager.Common;
using OrderManager.Model.DTO;



namespace OrderManager.Web
{
    public class LogController : BaseController
    {
        //日记

        public ViewResult Index(string key, int? pageIndex = 0, int? pageSize = 10)
        {
            string userId = "A54B09A0-9C39-45AF-AB06-CB6BA56F0315";
            UserServiceClient client = new UserServiceClient();
            List<OM_LogDataObject> list = client.GetCurrentUserLogs("test", userId);
            ViewBag.PageSize = pageSize;
            ViewBag.PageIndex = pageIndex;
            ViewBag.TotalPages = Math.Ceiling(Convert.ToDouble(list.Count) / Convert.ToDouble(pageSize));
            var result = list.Skip(Convert.ToInt32(pageIndex * pageSize)).Take((int)pageSize).ToList();
            return View("~/views/log/index.cshtml", result);



        }

        //留言板
        public ViewResult MessageBoard(string key, int? pageIndex = 0, int? pageSize = 10)
        {

            List<OM_MessageBoard> list = new List<OM_MessageBoard>() { 
            new OM_MessageBoard(){
            ID=1,
            Title="test",
            Name="test1",
            Message="adfklajfdlkaf jlkdafj kldajf lkdajddffdkjfhjfkafhiyafhjkadshkja kh kaafkhdfkh",
            Email="www@aa.com",
            PhoneNumber="155189238",
            User_Guid="tret"
            }
            };

            ViewBag.PageSize = pageSize;
            ViewBag.PageIndex = pageIndex;
            ViewBag.TotalPages = Math.Ceiling(Convert.ToDouble(list.Count) / Convert.ToDouble(pageSize));
            var result = list.Skip(Convert.ToInt32(pageIndex * pageSize)).Take((int)pageSize).ToList();
            return View("~/views/log/messageBoard.cshtml", result);
        }

        public ViewResult LeaveMessage()
        {
            OM_User model = new OM_User() { Name = "randy", Account = "111" + new Random().Next() };

            return View("~/Views/log/leavemessage.cshtml", model);
        }

    }
}
