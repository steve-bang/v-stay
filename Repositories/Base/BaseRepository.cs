using VStay_Backend.Models.Filters.Base;

namespace VStay_Backend.Repositories.Base
{
    /// <summary>
    /// This is the base class for all repositories in the system.<br/>
    /// </summary>
    public abstract class BaseRepository<T, ID> : IBaseRepository<T, ID>
    {
        /// <inheritdoc/>
        public abstract ID Create(T entity);

        /// <inheritdoc/>
        public abstract bool Delete(ID id);

        /// <inheritdoc/>
        public abstract T? GetById(ID id);

        /// <inheritdoc/>
        public abstract IEnumerable<T> List(IBaseFilter filter);

        /// <inheritdoc/>
        public abstract IEnumerable<T> List(IBaseFilter filter, out long totalItems);

        /// <inheritdoc/>
        public abstract bool Update(T entity);
    }
}
