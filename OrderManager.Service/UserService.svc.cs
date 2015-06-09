using Microsoft.Practices.Unity;
using OrderManager.Manager;
using OrderManager.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace OrderManager.Service
{

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [Aop.VerifyAuthority]
    [Aop.CatchWcfException]
    [Aop.WCFTransaction]
    public class UserService : IUserService
    {
        [Dependency]
        public IUserManager UserManager { get; set; }


        public OM_UserAuthority Login(string userAccount, string password)
        {
            var result = UserManager.Login(userAccount, password);
            if (result == false)
                throw new GenericException("账户或密码错误，请再次检查输入");

            var user = UserManager.GetUser(f => f.Account == userAccount && f.Pwd == password);

            var re = UserManager.GetUserAuthority(user.Guid);
            return re;
        }
    }
}
