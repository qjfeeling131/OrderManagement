
using OrderManager.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Manager
{
    public interface IOrderManger
    {
        #region Save Method
         bool SaveProduct(OM_Product product);

         bool SaveSalesOrder(OM_SalesOrder saleOrder);
         bool SaveSalesOrderItem(OM_SalesOrderItem saleOrderItem);
        #endregion

        #region Update Method
         bool UpdateProduct(OM_Product product);

         bool UpdateSalesOrder(OM_SalesOrder saleOrder);
         bool UpdateSalesOrderItem(OM_SalesOrderItem saleOrderItem);
        #endregion

        #region Update Method
         bool DeleteProduct(Expression<Func<OM_Product, bool>> product);

         bool UpdateSalesOrder(Expression<Func<OM_SalesOrder, bool>> saleOrder);
         bool DeleteSalesOrderItem(Expression<Func<OM_SalesOrderItem, bool>> saleOrderItem);
        #endregion

        #region Get ont or manay object

         IList<OM_Product> GetProductList(int PageIndex, int PageSize, Expression<Func<OM_Product, bool>> fuc, Expression<Func<OM_Product, bool>> orderFuc);

         OM_Product GetProduct(Expression<Func<OM_Product, bool>> fuc);
         IList<OM_SalesOrder> GetSalesOrderList(int PageIndex, int PageSize, Expression<Func<OM_SalesOrder, bool>> fuc, Expression<Func<OM_SalesOrder, bool>> orderFuc);

         OM_SalesOrder GetSalesOrder(Expression<Func<OM_SalesOrder, bool>> fuc);

         IList<OM_SalesOrderItem> GetSalesOrderItemList(int PageIndex, int PageSize, Expression<Func<OM_SalesOrderItem, bool>> fuc, Expression<Func<OM_SalesOrderItem, bool>> orderFuc);
         OM_SalesOrderItem GetSalesOrderItem(Expression<Func<OM_SalesOrderItem, bool>> fuc);
        #endregion
    }
}
