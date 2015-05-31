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
    //IIS 寄宿  -》 采用http协议   
    //WAS寄宿 ->协议： .net.tcp   .net.pipe .net.msmq
    //winform , console , window service 寄宿
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [Aop.Init]
    [Aop.CatchWcfException]
    public class TestService : ITestService
    {
        [Dependency]
        public IUserManager UserManger { get; set; }


        //[Aop.BeforeMethod]
        //[Aop.WCFTransaction()]
        [Aop.VerifyAuthority]
        public void GetData()
        {
            //UserManger.Add();
        }

        [Aop.CatchWcfException]
        public void ThrowFault()
        {
            int j = 1;
            int i = 1 / (j-1);
        }
    }


}
