using System.Collections.Generic;

namespace Service.IService.SysManage
{
    /// <summary>
    /// Service 授权验证模块对应接口
    /// </summary>
    public interface IPermissionManage : IRepository<Domain.SYS_PERMISSION>
    {
        /// <summary>
        /// 根据系统ID获取所有模块的权限ID集合
        /// </summary>
        /// <param name="sysId"></param>
        /// <returns></returns>
        List<int> GetPermissionIdBySysId(string sysId);
    }
}