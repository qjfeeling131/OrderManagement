using Aspect;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OrderManager.Service.Aop
{
    public class WCFTransactionAttribute : TransactionAttribute
    {
    }
}
