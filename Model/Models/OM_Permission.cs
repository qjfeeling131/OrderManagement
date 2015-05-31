using System;
using System.Collections.Generic;

namespace OrderManager.Model.Models
{
    public partial class OM_Permission
    {
        public int ID { get; set; }
        public string Guid { get; set; }
        public int Parent { get; set; }
        public string Name { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public short FormMethod { get; set; }
        public short OperationType { get; set; }
        public string Ico { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<bool> IsLink { get; set; }
        public string LinkUrl { get; set; }
        public bool IsShow { get; set; }
        public string Remark { get; set; }
        public bool IsDel { get; set; }
        public Nullable<System.DateTime> CreateDatetime { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    }
}
