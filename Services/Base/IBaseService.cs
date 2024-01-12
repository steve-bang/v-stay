using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Pageable;

namespace VStay_Backend.Services.Base
{
    /// <summary>
    /// This is the base interface for all services in the system.<br/>
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    /// <typeparam name="ID">The type id of the entity.</typeparam>
    public interface IBaseService<T, ID, F> 
        where T : class
        where ID : class
        where F : IBaseFilter
    {
        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="entity">The entity data to create.</param>
        /// <returns></returns>
        T Create(T entity);

        /// <summary>
        /// Updates a entity.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        /// <param name="entity">The entity data to update.</param>
        /// <returns></returns>
        T Update (ID id, T entity);

        /// <summary>
        /// Gets an entity by the given id.
        /// </summary>
        /// <param name="id">The id of the entity.</param>
        /// <returns></returns>
        T GetById (ID id);

        /// <summary>
        /// Deletes an entity by the given id. 
        /// </summary>
        /// <param name="id">The id of the entity to delete.</param>
        /// <returns></returns>
        bool DeleteById (ID id);

        /// <summary>
        /// Gets the list of the entity.
        /// </summary>
        /// <param name="filter">The filter object.</param>
        /// <returns></returns>
        IEnumerable<T> List(F filter);

        /// <summary>
        /// Gets the list of the entity with pagination.
        /// </summary>
        /// <param name="filter">The filter object.</param>
        /// <returns></returns>
        CPageble<T> ListPageble(F filter);
    }
}
