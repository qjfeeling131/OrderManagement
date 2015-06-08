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

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]   
    [Aop.VerifyAuthority]
    [Aop.CatchWcfException]
    public class BaseService 
    {
  
    }


}
