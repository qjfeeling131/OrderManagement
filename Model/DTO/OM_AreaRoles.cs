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
    public class OM_AreaRoles
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Guid { get; set; }
        [DataMember]
        public string Department_Guid { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ParentID { get; set; }
        [DataMember]
        public Nullable<bool> IsDel { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreateDatetiime { get; set; }
        [DataMember]
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        [DataMember]
        List<OM_AreaRoles> childRoles { get; set; }
    }


}
