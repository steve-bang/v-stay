using VStay_Backend.Dao.Implements;
using VStay_Backend.Dao.Interfaces;
using VStay_Backend.Models.Entities;
using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Pageable;
using VStay_Backend.Repositories.Interfaces;

namespace VStay_Backend.Repositories.Implements
{
    /// <summary>
    /// Defines repository for the Permission entity.
    /// </summary>
    public class PermisionRepository :IPermissionRepository
    {
        /// <summary>
        /// The permission dao object.
        /// </summary>
        private readonly IPermissionDao _permissionDao = new PermissionDao();

        #region Construtor

        public PermisionRepository() { }

        #endregion

        /// <inheritdoc/>
        public long Create(PermissionEntity entity)
        {
            try
            {
                return _permissionDao.Create(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <inheritdoc/>
        public bool Delete(long id)
        {
            try
            {
                return _permissionDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <inheritdoc/>
        public bool Update(PermissionEntity entity)
        {
            try
            {
                return _permissionDao.Update(entity);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <inheritdoc/>
        public PermissionEntity? GetById(long id)
        {
            try
            {
                return _permissionDao.Get(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<PermissionEntity> List(IBaseFilter filter)
        {
            try
            {
                return _permissionDao.List(filter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <inheritdoc/>
        public CPageble<PermissionEntity> ListPageble(IBaseFilter filter)
        {
            try
            {
                long totalItems = 0;

                IEnumerable<PermissionEntity> permissionEntities = _permissionDao.List(filter, out totalItems);

                return new CPageble<PermissionEntity>(permissionEntities, totalItems);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
