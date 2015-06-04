using OrderManager.Model;
using OrderManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Manager
{

    public abstract class BaseManger
    {
        [Microsoft.Practices.Unity.Dependency]
        public IDatabaseRepository DbRepository { get; set; }
    }
}
