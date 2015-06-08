using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManager.Service
{

    public class UtilsService : BaseService, IUtilsService
    {
        //每个方法都用 用guid () 用对称加密
        public void DoWork(string Hash)
        {

        }
    }
}
