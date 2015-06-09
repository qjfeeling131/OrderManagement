using OrderManager.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManager.Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUserService”。
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        OM_UserAuthority Login(string userAccount, string password);

        //[OperationContract]
        //OM_UserAuthority GetUserAuthority(string userGuid);


        //[OperationContract]
        //OM_User GetUserList(string cipher, string userGuid);

    }
}
