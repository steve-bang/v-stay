using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Pageable;
using VStay_Backend.Models.Response;
using VStay_Backend.Models.Response.Base;

namespace VStay_Backend.Services.Base
{
    /// <summary>
    /// This is the base interface for all services in the system.<br/>
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public interface IBaseService<T, ID, F> 
        where T : class
        where F : IBaseFilter
    {
        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="entity">The entity data to create.</param>
        /// <returns></returns>
        ResponseApi Create(T entity);

        /// <summary>
        /// Updates a entity.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        /// <param name="entity">The entity data to update.</param>
        /// <returns></returns>
        ResponseApi Update (long id, T entity);

        /// <summary>
        /// Gets an entity by the given id.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        /// <returns></returns>
        ResponseApi GetById (long id);

        /// <summary>
        /// Deletes an entity by the given id. 
        /// </summary>
        /// <param name="id">The id of the entity to delete.</param>
        /// <returns></returns>
        ResponseApi DeleteById (long id);

        /// <summary>
        /// Gets the list of the entity.
        /// </summary>
        /// <param name="filter">The filter object.</param>
        /// <returns></returns>
        ResponseApi List(F filter);

        /// <summary>
        /// Gets the list of the entity with pagination.
        /// </summary>
        /// <param name="filter">The filter object.</param>
        /// <returns></returns>
        ResponseApi ListPageble(F filter);
    }
}
