using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using System.ServiceModel;
using OrderManager.Web.Models;
using OrderManager.Model.Models;
using System.Web.Script.Serialization;


namespace OrderManager.Web
{
    public class BaseController : Controller
    {

        //public ICache Cache { get; set; }
        public ViewResult Exception(Models.InfoModel model)
        {
            if (model == null)
                model = new InfoModel();
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
            InfoModel errormodel = new InfoModel() { Title = "错误"};
            JsonModel resultModel = new JsonModel() { Code = 0 };
            var wcfException = filterContext.Exception as FaultException<ExceptionDetail>;
            if (wcfException != null)
            {

                //string json = GetWcfExceptionDetail(wcfException.Detail);
                //var result = Common.Serializer.DeserilizeJson<OM_ExceptionMessage>(json);
                errormodel.Message = GetWcfExceptionDetail(wcfException.Detail);// result.Message;
                //model.Code = result.Code;
            }
            else
            {
                errormodel.Message = GetExceptionDetail(filterContext.Exception);
            }

            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {

                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                resultModel.Data = "createDialog('" + Url.Content("~/base/exception") + "'," + jsonSerializer.Serialize(errormodel) + ")";
                filterContext.Result = Json(resultModel);
            }
            //filterContext.Result = JavaScript("createDialog('" + Url.Content("~/base/exception") + "')");
            else
                filterContext.Result = View("~/Views/Template/ExceptionPage.cshtml", errormodel);

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
