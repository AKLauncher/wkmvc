using Domain;

namespace Service.IService.SysManage
{
    public interface IUserRoleManage:IRepository<SYS_USER_ROLE>
    {
        /// <summary>
        /// 设置用户角色
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool SetUserRole(int userId, string roleId);
    }
}