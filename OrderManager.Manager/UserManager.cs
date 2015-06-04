﻿
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

        public UserManager()
        {

        }
        #region Save Method
        public bool SaveUer(OM_User user)
        {
            if (DbRepository.Add(user) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveLog(OM_Log log)
        {
            if (DbRepository.Add(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveDepartment(OM_Department dep)
        {
            if (DbRepository.Add(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool SaveRole(OM_Role role)
        {
            if (DbRepository.Add(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveRolePermission(OM_RolePermission rolePermission)
        {
            if (DbRepository.Add(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveUserRole(OM_UserRole userRole)
        {
            if (DbRepository.Add(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool SavePermission(OM_Permission permission)
        {
            if (DbRepository.Add(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Update Method
        public bool UpdateUer(OM_User user)
        {
            if (DbRepository.Update(user) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateLog(OM_Log log)
        {
            if (DbRepository.Update(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateDepartment(OM_Department dep)
        {
            if (DbRepository.Update(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateRole(OM_Role role)
        {
            if (DbRepository.Update(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateRolePermission(OM_RolePermission rolePermission)
        {
            if (DbRepository.Update(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateUserRole(OM_UserRole userRole)
        {
            if (DbRepository.Update(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePermission(OM_Permission permission)
        {
            if (DbRepository.Update(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Delete Method
        public bool DeleteUer(Expression<Func<OM_User, bool>> func)
        {
            if (DbRepository.Delete(func) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteLog(Expression<Func<OM_Log, bool>> log)
        {
            if (DbRepository.Update(log) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteDepartment(Expression<Func<OM_Department, bool>> dep)
        {
            if (DbRepository.Update(dep) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteRole(Expression<Func<OM_Role, bool>> role)
        {
            if (DbRepository.Update(role) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteRolePermission(Expression<Func<OM_RolePermission, bool>> rolePermission)
        {
            if (DbRepository.Update(rolePermission) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteUserRole(Expression<Func<OM_UserRole, bool>> userRole)
        {
            if (DbRepository.Update(userRole) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletePermission(Expression<Func<OM_Permission, bool>> permission)
        {
            if (DbRepository.Update(permission) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Get one or manay Object 
        public IList<OM_User> GetUserList(int PageIndex, int PageSize, Expression<Func<OM_User, bool>> fuc, Expression<Func<OM_User, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }
        public OM_User GetUser(Expression<Func<OM_User, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }

        public IList<OM_Log> GetLogList(int PageIndex, int PageSize, Expression<Func<OM_Log, bool>> fuc, Expression<Func<OM_Log, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Log GetLog(Expression<Func<OM_Log, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }
        public IList<OM_Permission> GetPermissionList(int PageIndex, int PageSize, Expression<Func<OM_Permission, bool>> fuc, Expression<Func<OM_Permission, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Permission GetPermission(Expression<Func<OM_Permission, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }

        public IList<OM_Department> GetDepartmentList(int PageIndex, int PageSize, Expression<Func<OM_Department, bool>> fuc, Expression<Func<OM_Department, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Department GetDepartment(Expression<Func<OM_Department, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }

        public IList<OM_Role> GetRoleList(int PageIndex, int PageSize, Expression<Func<OM_Role, bool>> fuc, Expression<Func<OM_Role, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_Role GetRole(Expression<Func<OM_Role, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }

        public IList<OM_RolePermission> GetRolePermissionList(int PageIndex, int PageSize, Expression<Func<OM_RolePermission, bool>> fuc, Expression<Func<OM_RolePermission, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_RolePermission GetRolePermission(Expression<Func<OM_RolePermission, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }


        public IList<OM_UserRole> GetUserRoleList(int PageIndex, int PageSize, Expression<Func<OM_UserRole, bool>> fuc, Expression<Func<OM_UserRole, bool>> orderFuc)
        {
            return DbRepository.GetPagedList(PageIndex, PageSize, fuc, orderFuc);

        }

        public OM_UserRole GetUserRole(Expression<Func<OM_UserRole, bool>> fuc)
        {
            return DbRepository.GetModel(fuc);

        }
        #endregion
    }
}