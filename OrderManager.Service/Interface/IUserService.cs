﻿using OrderManager.Model.DTO;
using OrderManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManager.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        OM_UserAuthority Login(string userAccount, string password);

        [OperationContract]
        void Test(string cipher, string aaa);

        [OperationContract]
        List<OM_LogDataObject> GetCurrentUserLogs(string cipher, string userId);
    }
}
