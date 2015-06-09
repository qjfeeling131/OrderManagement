using Microsoft.Practices.Unity;
using OrderManager.Manager;
using OrderManager.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManager.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“UserService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 UserService.svc 或 UserService.svc.cs，然后开始调试。
    public class UserService : BaseService, IUserService
    {
        [Dependency]
        public IUserManager UserManager { get; set; }


        public OM_UserAuthority Login(string userAccount, string password)
        {
            var result = UserManager.Login(userAccount, password);
            if (result == false)
                throw new GenericException("账户或密码错误，请再次检查输入");

            var user = UserManager.GetUser(f => f.Account == userAccount && f.Pwd == password);

            return UserManager.GetUserAuthority(user.Guid);
        }

    }
}
