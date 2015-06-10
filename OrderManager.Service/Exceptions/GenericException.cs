using OrderManager.Common;
using OrderManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace OrderManager.Service
{
    public class GenericException : Exception
    {

        protected string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Code { get; set; }

        public GenericException()
        {
        }

        public GenericException(Exception ex)
            : base("", ex)
        {
            this._message = ex.Message;
        }

        public GenericException(string message, string code)
        {
            //OM_ExceptionMessage model = new OM_ExceptionMessage() { Message = message, Code = code };
            //string jsonStr = Serializer.SerilizeAsJson(model);
            this._message = message;
        }

    }


}
