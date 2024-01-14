using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Pageable;

namespace VStay_Backend.Repositories.Base
{
    /// <summary>
    /// This is the base interface for all repositories in the system.<br/>
    /// </summary>
    public interface IBaseRepository<T>
    {

        /// <summary>
        /// Creates a new entity to the database.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The id of the entity.</returns>
        long Create(T entity);

        /// <summary>
        /// Updates the entity in the database.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>True if the entity was updated successfully, otherwise false.</returns>
        bool Update(T entity);

        /// <summary>
        /// Deletes the entity from the database.
        /// </summary>
        /// <param name="entityId">The id of the entity to delete.</param>
        /// <returns>True if the entity was deleted successfully, otherwise false.</returns>
        bool Delete(long id);

        /// <summary>
        /// Gets the entity by id.
        /// </summary>
        /// <param name="entityId">The id of the entity.</param>
        /// <returns>Returns the entity, if the entity is not exists we return null.</returns>
        T? GetById (long id);

        /// <summary>
        /// Gets the list of the entities with the filter.
        /// </summary>
        /// <param name="filter">The filter to use.</param>
        /// <returns>The list of entities.</returns>
        IEnumerable<T> List(IBaseFilter filter);

        /// <summary>
        /// Gets the entity list with the filter.
        /// </summary>
        /// <param name="totalItems">The number of records that match the filter.</param>
        /// <returns>The list of entities.</returns>
        CPageble<T> ListPageble(IBaseFilter filter);

    }
}
