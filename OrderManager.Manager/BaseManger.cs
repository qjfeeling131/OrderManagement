using OrderManager.Model;
using OrderManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Manager
{
    public interface IBaseManager 
    {
        void Add<T>(T obj) ;
        void Update( );
        void Delete();
        void GetData();
    }

    public abstract class BaseManger:IBaseManager
    {
        public IDatabaseRepository DbContext { get; set; }

        public void Test()
        {
 
        }

        public void Add<T>(T obj)
        {
          
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
