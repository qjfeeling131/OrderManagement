using AutoMapper;
using OrderManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model.DTO
{
    [DataContract]
    public class OM_UserAuthority
    {
        [DataMember]
        public OM_User User { get; set; }

        [DataMember]
        public OM_Role Role { get; set; }

        [DataMember]
        public string AreaName { get; set; }

        [DataMember]
        public string DepartmentName { get; set; }

        [DataMember]
        public IList<OM_Permission> Permission { get; set; }

    }


}
