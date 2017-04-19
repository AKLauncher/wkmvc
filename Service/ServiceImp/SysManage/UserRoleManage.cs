using System;
using System.Linq;
using Domain;
using Service.IService.SysManage;

namespace Service.ServiceImp
{
    public class UserRoleManage:RepositoryBase<SYS_USER_ROLE>,IUserRoleManage
    {
        public bool SetUserRole(int userId, string roleId)
        {
            try
            {
                //删除用户角色
                Delete(p => p.FK_USERID == userId);
                //设置当前用户角色
                if (string.IsNullOrEmpty(roleId))
                {
                    return true;
                }
                foreach (var entity in roleId.Split(',').Select(t=>new SYS_USER_ROLE
                {
                    FK_USERID = userId,
                    FK_ROLEID = int.Parse(t)
                }))
                {
                    _Context.Set<SYS_USER_ROLE>().Add(entity);
                }
                return _Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}