namespace Service.IService.SysManage
{
    public interface IUserPermissionManage : IRepository<Domain.SYS_USER_PERMISSION>
    {
        /// <summary>
        /// 设置用户权限
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newper"></param>
        /// <param name="sysId"></param>
        /// <returns></returns>
        bool SetUserPermission(int userId, string newper);
    }
}