using VStay_Backend.Models.Cores.Permission;
using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Filters.Implements;
using VStay_Backend.Services.Base;

namespace VStay_Backend.Services
{
    public interface IPermissionService : IBaseService<CPermission, long, PermissionFilter>
    {
    }
}
