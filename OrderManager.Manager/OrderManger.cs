
using OrderManager.Model.Models;
using OrderManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Manager
{
    public class OrderManger : BaseManger, IOrderManger
    {

        [Microsoft.Practices.Unity.Dependency]
        public IDatabaseRepository dbRepository { get; set; }
        public OrderManger()
        {

        }

        #region Save Method
        public bool SaveProduct(OM_Product product)
        {
            if (dbRepository.Add(product) > 0)
            {
                return true;
            }
            return false;
        }

        public bool SaveSalesOrder(OM_SalesOrder saleOrder)
        {
            if (dbRepository.Add(saleOrder) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveSalesOrderItem(OM_SalesOrderItem saleOrderItem)
        {
            if (dbRepository.Add(saleOrderItem) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Update Method
        public bool UpdateProduct(OM_Product product)
        {
            if (dbRepository.Update(product) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSalesOrder(OM_SalesOrder saleOrder)
        {
            if (dbRepository.Update(saleOrder) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateSalesOrderItem(OM_SalesOrderItem saleOrderItem)
        {
            if (dbRepository.Update(saleOrderItem) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Update Method
        public bool DeleteProduct(Expression<Func<OM_Product, bool>> product)
        {
            if (dbRepository.Delete(product) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateSalesOrder(Expression<Func<OM_SalesOrder, bool>> saleOrder)
        {
            if (dbRepository.Delete(saleOrder) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteSalesOrderItem(Expression<Func<OM_SalesOrderItem, bool>> saleOrderItem)
        {
            if (dbRepository.Delete(saleOrderItem) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region  Get one or manay Object

        public IList<OM_Product> GetProductList(int PageIndex, int PageSize, Expression<Func<OM_Product, bool>> fuc, Expression<Func<OM_Product, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Product GetProduct(Expression<Func<OM_Product, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_SalesOrder> GetSalesOrderList(int PageIndex, int PageSize, Expression<Func<OM_SalesOrder, bool>> fuc, Expression<Func<OM_SalesOrder, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_SalesOrder GetSalesOrder(Expression<Func<OM_SalesOrder, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_SalesOrderItem> GetSalesOrderItemList(int PageIndex, int PageSize, Expression<Func<OM_SalesOrderItem, bool>> fuc, Expression<Func<OM_SalesOrderItem, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_SalesOrderItem GetSalesOrderItem(Expression<Func<OM_SalesOrderItem, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        } 
        #endregion
    }
}
