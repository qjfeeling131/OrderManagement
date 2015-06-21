using Microsoft.Practices.Unity;
using OrderManager.Common;
using OrderManager.Manager;
using OrderManager.Model.DTO;
using OrderManager.Model.Models;
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
                throw new GenericException("账户或密码错误，请再次检查输入", OM_ExceptionCodeEnum.LOGIN.ToString());

            var user = UserManager.GetUser(f => f.Account == userAccount && f.Pwd == password);

            user.Key = Encryptor.GenerateKey();
            UserManager.UpdateUer(user);

            var re = UserManager.GetUserAuthority(user.Guid);
            return re;
        }

        public List<OM_LogDataObject> GetCurrentUserLogs(string cipher, string userId)
        {
            return UserManager.GetCurrentUserLogs(userId);
        }


        public void Test(string cipher, string aaa)
        {
            throw new NotImplementedException();
        }
    }
}
