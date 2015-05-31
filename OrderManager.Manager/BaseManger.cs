using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Manager
{
    public class BaseManger
    {
        public IDatabaseRepository DbContext { get; set; }
        
    }
}
