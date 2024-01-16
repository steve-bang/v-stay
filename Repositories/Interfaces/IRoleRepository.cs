using VStay_Backend.Models.Entities;
using VStay_Backend.Repositories.Base;

namespace VStay_Backend.Repositories.Interfaces
{
    /// <summary>
    /// This interface is used to define data repository for the permission entity.
    /// </summary>
    public interface IRoleRepository : IBaseRepository<RoleEntity>
    {
    }
}
