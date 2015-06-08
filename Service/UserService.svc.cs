using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microsoft.Practices.Unity;
using System.ServiceModel.Activation;
using System.Threading.Tasks;
using Aspect;
using System.Transactions;
using OrderManager.Manager;

namespace OrderManager.Service
{

    public class UserService : BaseService, ITestService
    {
        [Dependency]
        public IUserManager UserManger { get; set; }

        public void GetData()
        {
        }



        public void ThrowFault()
        {
            int j = 1;
            int i = 1 / (j - 1);
        }
    }


}
