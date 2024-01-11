using VStay_Backend.Models.Filters.Base;

namespace VStay_Backend.Dao.Base
{
    /// <summary>
    /// Defines the generic base interface for all DAOs in the system.<br/>
    /// It is used to provide a common base interface for all DAOs.
    /// </summary>
    public interface IBaseDao<T>
    {

        /// <summary>
        /// Creates a new record in the database then returns the id of the new record.
        /// </summary>
        /// <param name="id">The entity to create.</param>
        /// <returns>The id of the new record.</returns>
        long Create(T entity);

        /// <summary>
        /// Updates a record in the database then returns the affected rows.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>The affected rows.</returns>
        long Update(T entity);

        /// <summary>
        /// Deletes a record from the database then returns the affected rows.
        /// </summary>
        /// <param name="id">The Id of the entity to delete.</param>
        /// <returns>The affected rows.</returns>
        long Delete(long id);

        /// <summary>
        /// Gets a record from the database by an id.
        /// </summary>
        /// <param name="id">The id of the record to get.</param>
        /// <returns>The entity.</returns>
        T Get (long id);

        /// <summary>
        /// Gets all records from the database with the given filter.
        /// </summary>
        /// <param name="filter">The base filter.</param>
        /// <returns>The entities.</returns>
        IEnumerable<T> List(IBaseFilter filter);

        /// <summary>
        /// Gets all records from the database with the given filter, then converts them to entities.
        /// </summary>
        /// <param name="count">The total number of records that match the filter.</param>
        /// <param name="filter">The filter to apply.</param>
        /// <returns>The entities.</returns>
        IEnumerable<T> List(out int TotalRows, IBaseFilter filter);
    }
}
