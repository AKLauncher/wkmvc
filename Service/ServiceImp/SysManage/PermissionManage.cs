using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Service.IService.SysManage;

namespace Service.ServiceImp
{
    public class PermissionManage : RepositoryBase<Domain.SYS_PERMISSION>, IPermissionManage
    {
        public List<int> GetPermissionIdBySysId(string sysId)
        {
            try
            {
                var sql ="select p.id from sys_permission p where exists(select 1 from sys_module t where t.fk_belongsystem=@sysid and t.id=p.moduleid)";
                DbParameter para=new SqlParameter("@sysid", sysId);

                return SelectBySql<int>(sql, para);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}