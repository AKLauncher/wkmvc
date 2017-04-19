using Domain;

namespace Service.IService.SysManage
{
    /// <summary>
    /// Service层基本用户信息接口
    /// </summary>
    public interface IUserManage:IRepository<SYS_USER>
    {
        /// <summary>
        /// 管理用户登录验证并返回用户信息与权限集合
        /// </summary>
        /// <param name="useraccount">用户账号</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>
        SYS_USER UserLogin(string useraccount, string password);
        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        bool IsAdmin(int userId);
        /// <summary>
        /// 根据用户ID获取用户名,不存在则返回空
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        string GetUserName(int userId);
        /// <summary>
        /// 根据用户ID获取本职部门名称
        /// </summary>
        string GetUserDptName(int id);
        /// <summary>
        /// 删除用户
        /// </summary>
        bool Remove(int userId);
        /// <summary>
        /// 根据用户构造用户基本信息
        /// </summary>
        Account GetAccountByUser(Domain.SYS_USER user);
        /// <summary>
        /// 从Cookie中获取用户信息
        /// </summary>
        Account GetAccountByCookie();
    }
}