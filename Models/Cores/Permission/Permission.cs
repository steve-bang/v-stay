using VStay_Backend.Models.Cores.Base;
using VStay_Backend.Models.Entities;
using VStay_Backend.Models.Filters.Implements;
using VStay_Backend.Models.Pageable;
using VStay_Backend.Repositories.Implements;
using VStay_Backend.Repositories.Interfaces;

namespace VStay_Backend.Models.Cores.Permission
{
    public partial class CPermission : CBaseCoreModel
    {
        private static readonly IPermissionRepository _permissionRepository = new PermisionRepository();

        #region Constructor

        /// <summary>
        /// Initilize the permission object default.
        /// </summary>
        public CPermission() { }

        /// <summary>
        /// Initilize the permission object by the given permission entity.
        /// </summary>
        public CPermission(PermissionEntity permissionEntity)
        {
            Id = permissionEntity.Id;
            Name = permissionEntity.Name;
            Description = permissionEntity.Description;
            ModifiedBy = permissionEntity.ModifiedBy;
            ModifiedDate = permissionEntity.ModifiedDate;
            CreatedBy = permissionEntity.CreatedBy;
            CreatedDate = permissionEntity.CreatedDate;
        }

        #endregion

        #region Static Method

        /// <summary>
        /// Create a new permission.
        /// </summary>
        /// <param name="permission">The permission data to create.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Throw exception if create was an error.</exception>
        public static CPermission Create(CPermission permission)
        {
            // Maps to entity
            PermissionEntity permissionEntity = new PermissionEntity
            {
                Name = permission.Name,
                Description = permission.Description,
                CreatedBy = permission.CreatedBy,
            };
            // Get id created entity.
            long idCreated = _permissionRepository.Create(permissionEntity);

            CPermission? permissionCreated = Get(idCreated);
            // If the entity created is null, it means the creation was error.
            if (permissionCreated == null)
            {
                throw new Exception("Created a new permission was an error.");
            }
            // Returns result entity.
            return permissionCreated;
        }

        /// <summary>
        /// Deletes a entity by the given id
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <returns></returns>
        public static bool DeleteById(long id)
        {
            // Delete an entity by the given id
            bool result = _permissionRepository.Delete(id);
            return result;
        }

        /// <summary>
        /// Updates a entity by the given id. 
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        /// <param name="permission">The entity data to update.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool UpdateById(long id, CPermission permission)
        {
            CPermission? permissionFound = Get(id);

            if (permissionFound == null)
            {
                throw new Exception($"Permission {permission.Id} not found");
            }

            permissionFound.Name = permission.Name;
            permissionFound.Description = permission.Description;

            PermissionEntity permissionEntity = new PermissionEntity
            {
                Id = id,
                Name = permission.Name,
                Description = permission.Description,
                ModifiedBy = permission.ModifiedBy,
            };

            bool result = _permissionRepository.Update(permissionEntity);
            return result;

        }

        /// <summary>
        /// Get a entity by the given id.
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <returns></returns>
        public static CPermission? Get(long id)
        {
            PermissionEntity? permissionEntity = _permissionRepository.GetById(id);
            if (permissionEntity == null)
            {
                return null;
            }

            return new CPermission(permissionEntity);

        }

        /// <summary>
        /// Gets first by the given filter.
        /// </summary>
        /// <param name="permissionFilter">The filter object.</param>
        /// <returns></returns>
        public static CPermission? Get(PermissionFilter permissionFilter)
        {
            return List(permissionFilter).FirstOrDefault();
        }

        /// <summary>
        /// Gets the list of the entity by the given filter.
        /// </summary>
        /// <param name="permissionFilter">The filter object.</param>
        /// <returns></returns>
        public static IEnumerable<CPermission> List(PermissionFilter permissionFilter)
        {
            IEnumerable<PermissionEntity> permissionEntities = _permissionRepository.List(permissionFilter);

            foreach (PermissionEntity permissionEntity in permissionEntities)
            {
                yield return new CPermission(permissionEntity);
            }
        }

        /// <summary>
        /// Gets the pagination result of the entity.
        /// </summary>
        /// <param name="permissionFilter">The filter object.</param>
        /// <returns></returns>
        public static CPageble<CPermission> ListPageble(PermissionFilter permissionFilter)
        {

            CPageble<PermissionEntity> permissionPageble = _permissionRepository.ListPageble(permissionFilter);

            List<CPermission> permissions = new List<CPermission>();

            if ( permissionPageble != null )
            {

                IEnumerable<PermissionEntity> permissionEntities = permissionPageble.Items;

                foreach (PermissionEntity permissionEntity in permissionEntities)
                {
                    permissions.Add(new CPermission(permissionEntity));
                }

                return new CPageble<CPermission>(permissions, permissionPageble.TotalItems);
           
            }

            return new CPageble<CPermission>();
        }

        #endregion
    }
}
