using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using System.ServiceModel;
using OrderManager.Web.Models;
using OrderManager.Model.Models;


namespace OrderManager.Web
{
    public class BaseController : Controller
    {

        //public ICache Cache { get; set; }
        public ViewResult Exception(Models.ErrorModel model)
        {
            if (model == null)
                model = new ErrorModel();
            return View("~/Views/Template/Exception.cshtml", model);
        }


        protected string GetCookie(string key)
        {
            var cookie = HttpContext.Request.Cookies[key];
            if (cookie != null)
                return cookie.Value;
            return null;
        }

        protected void SetCookie(string key, string value, DateTime timeout)
        {
            var cookie = HttpContext.Response.Cookies[key];
            if (cookie == null)
            {
                cookie = new HttpCookie(key, value);
                cookie.Expires = timeout;
                HttpContext.Response.AppendCookie(cookie);
            }
            else
            {
                cookie.Value = value;
                cookie.Expires = timeout;
                HttpContext.Response.SetCookie(cookie);
            }

        }

        public BaseController()
        {
            //Cache = Tools.DistrubutedCache;
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            //filterContext.
            base.OnAuthorization(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            ErrorModel model = new ErrorModel();

            var wcfException = filterContext.Exception as FaultException<ExceptionDetail>;
            if (wcfException != null)
            {

                //string json = GetWcfExceptionDetail(wcfException.Detail);
                //var result = Common.Serializer.DeserilizeJson<OM_ExceptionMessage>(json);
                model.Message = GetWcfExceptionDetail(wcfException.Detail);// result.Message;
                //model.Code = result.Code;
            }
            else
            {
                model.Message = GetExceptionDetail(filterContext.Exception);
            }

            filterContext.Result = JavaScript("createDialog('" + Url.Content("~/base/exception") + "')");

        }

        private string GetWcfExceptionDetail(ExceptionDetail ex)
        {
            string str = string.Concat(ex.Message, "  "); // ex.StackTrace
            if (ex.InnerException != null)
            {
                str = string.Concat(str, this.GetWcfExceptionDetail(ex.InnerException));
            }
            return str;
        }

        private string GetExceptionDetail(Exception ex)
        {
            string str = string.Concat(ex.Message, "  "); //ex.StackTrace
            if (ex.InnerException != null)
            {
                str = string.Concat(str, this.GetExceptionDetail(ex.InnerException));
            }
            return str;
        }


    }
}
