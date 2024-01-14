
using VStay_Backend.Models.Cores.Permission;
using VStay_Backend.Models.Filters.Implements;
using VStay_Backend.Models.Pageable;
using VStay_Backend.Models.Response;

namespace VStay_Backend.Services
{
    /// <summary>
    /// The permission service.
    /// </summary>
    public partial class PermissionService : IPermissionService
    {
        
        /// <inheritdoc/>
        public ResponseApi Create(CPermission permission)
        {
            try
            {
                return new ResponseApi(CPermission.Create(permission));
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error while create a new permission at {nameof(Create)}. Detail: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public ResponseApi DeleteById(long id)
        {
            try
            {
                bool result = CPermission.DeleteById(id);
                return new ResponseApi(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at {nameof(DeleteById)}. Detail: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public ResponseApi GetById(long id)
        {
            try
            {
                CPermission? result = CPermission.Get(id);
                if(result == null)
                {
                    throw new Exception("Data not found.");
                }

                return new ResponseApi(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at {nameof(GetById)}. Detail: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public ResponseApi List(PermissionFilter filter)
        {
            try
            {
                IEnumerable<CPermission> permissions = CPermission.List(filter);

                return new ResponseApi(permissions);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at {nameof(List)}. Detail: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public ResponseApi ListPageble(PermissionFilter filter)
        {
            try
            {
                CPageble<CPermission> permissions = CPermission.ListPageble(filter);

                return new ResponseApi(permissions);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at {nameof(ListPageble)}. Detail: {ex.Message}");
            }
        }


        /// <inheritdoc/>
        public ResponseApi Update(long id, CPermission entity)
        {
            try
            {
                bool result = CPermission.UpdateById(id, entity);

                return new ResponseApi(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at {nameof(Update)}. Detail: {ex.Message}");
            }
        }
    }
}
