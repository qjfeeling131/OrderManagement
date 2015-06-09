using Aspect;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.Common;
using OrderManager.Manager;
using Microsoft.Practices.Unity;

namespace OrderManager.Service.Aop
{
    public class VerifyAuthorityAttribute : AuthenticationAttribute
    {

        //private IUserManager UserManager { get { return (IUserManager)MyUnityContainer.Instance.Resolve(typeof(IUserManager), "UserManager", null); } }

        [Dependency]
        private IUserManager UserManager { get; set; }

        public override void CheckAuthentication(IMethodInvocation input)
        {
            //Guid 加密后过来
            if (input.Arguments.ContainsParameter("cipher") == false)
                throw new GenericException("为确保账户安全,请重新登陆");
            //MyUnityContainer
            var key = input.Arguments["cipher"].ToString();
            //updatedatetime
            //Common.Encryptor.DecryptString()

            //UserManager.GetUser()

            Console.WriteLine("VerifyAuthority");
        }
    }
}
