using VStay_Backend.Models.Filters.Base;

namespace VStay_Backend.Dao.Base
{
    public abstract class BaseDao<T> : IBaseDao<T>
    {
        /// <inheritdoc/>
        public abstract long Create(T entity);

        /// <inheritdoc/>
        public abstract long Delete(long id);

        /// <inheritdoc/>
        public abstract T Get(long id);

        /// <inheritdoc/>
        public abstract IEnumerable<T> List(IBaseFilter filter);

        /// <inheritdoc/>
        public abstract IEnumerable<T> List(IBaseFilter filter, out int totalItems);

        /// <inheritdoc/>
        public abstract long Update(T entity);
    }
}
