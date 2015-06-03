
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
    public class UserManager : BaseManger, IUserManager
    {
        [Microsoft.Practices.Unity.Dependency]
        public IDatabaseRepository dbRepository { get; set; }
        public UserManager()
        {

        }
        #region Save Method
        public bool SaveUer(OM_User user)
        {
            if (dbRepository.Add(user) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveLog(OM_Log log)
        {
            if (dbRepository.Add(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveDepartment(OM_Department dep)
        {
            if (dbRepository.Add(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool SaveRole(OM_Role role)
        {
            if (dbRepository.Add(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveRolePermission(OM_RolePermission rolePermission)
        {
            if (dbRepository.Add(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveUserRole(OM_UserRole userRole)
        {
            if (dbRepository.Add(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool SavePermission(OM_Permission permission)
        {
            if (dbRepository.Add(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Update Method
        public bool UpdateUer(OM_User user)
        {
            if (dbRepository.Update(user) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateLog(OM_Log log)
        {
            if (dbRepository.Update(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateDepartment(OM_Department dep)
        {
            if (dbRepository.Update(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateRole(OM_Role role)
        {
            if (dbRepository.Update(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateRolePermission(OM_RolePermission rolePermission)
        {
            if (dbRepository.Update(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateUserRole(OM_UserRole userRole)
        {
            if (dbRepository.Update(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePermission(OM_Permission permission)
        {
            if (dbRepository.Update(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Delete Method
        public bool DeleteUer(Expression<Func<OM_User, bool>> func)
        {
            if (dbRepository.Delete(func) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteLog(Expression<Func<OM_Log, bool>> log)
        {
            if (dbRepository.Update(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteDepartment(Expression<Func<OM_Department, bool>> dep)
        {
            if (dbRepository.Update(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteRole(Expression<Func<OM_Role, bool>> role)
        {
            if (dbRepository.Update(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteRolePermission(Expression<Func<OM_RolePermission, bool>> rolePermission)
        {
            if (dbRepository.Update(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteUserRole(Expression<Func<OM_UserRole, bool>> userRole)
        {
            if (dbRepository.Update(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletePermission(Expression<Func<OM_Permission, bool>> permission)
        {
            if (dbRepository.Update(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Get one or manay Object 
        public IList<OM_User> GetUserList(int PageIndex, int PageSize, Expression<Func<OM_User, bool>> fuc, Expression<Func<OM_User, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }
        public OM_User GetUser(Expression<Func<OM_User, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_Log> GetLogList(int PageIndex, int PageSize, Expression<Func<OM_Log, bool>> fuc, Expression<Func<OM_Log, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Log GetLog(Expression<Func<OM_Log, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }
        public IList<OM_Permission> GetPermissionList(int PageIndex, int PageSize, Expression<Func<OM_Permission, bool>> fuc, Expression<Func<OM_Permission, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Permission GetPermission(Expression<Func<OM_Permission, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_Department> GetDepartmentList(int PageIndex, int PageSize, Expression<Func<OM_Department, bool>> fuc, Expression<Func<OM_Department, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Department GetDepartment(Expression<Func<OM_Department, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_Role> GetRoleList(int PageIndex, int PageSize, Expression<Func<OM_Role, bool>> fuc, Expression<Func<OM_Role, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Role GetRole(Expression<Func<OM_Role, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }

        public IList<OM_RolePermission> GetRolePermissionList(int PageIndex, int PageSize, Expression<Func<OM_RolePermission, bool>> fuc, Expression<Func<OM_RolePermission, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_RolePermission GetRolePermission(Expression<Func<OM_RolePermission, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }


        public IList<OM_UserRole> GetUserRoleList(int PageIndex, int PageSize, Expression<Func<OM_UserRole, bool>> fuc, Expression<Func<OM_UserRole, bool>> orderFuc)
        {
            return dbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_UserRole GetUserRole(Expression<Func<OM_UserRole, bool>> fuc)
        {
            return dbRepository.GetModel(fuc);

        }
        #endregion
    }
}