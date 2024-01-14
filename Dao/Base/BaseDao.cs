using System.Data;
using VStay_Backend.Models.Entities;
using VStay_Backend.Models.Filters.Base;

namespace VStay_Backend.Dao.Base
{
    public abstract class BaseDao<T> : IBaseDao<T>
        where T : BaseEntity<T>
    {
        private readonly DbClient _dbClient;


        /// <summary>
        /// The name of the stored procedure to insert an entity.
        /// </summary>
        protected string StoredProcedureInsert { get; set; } = string.Empty;

        /// <summary>
        /// The name of the stored procedure to get an entity by id.
        /// </summary>
        protected string StoredProcedureGet { get; set; } = string.Empty;

        /// <summary>
        /// The name of the stored procedure to get all entities.
        /// </summary>
        protected string StoredProcedureList { get; set; } = string.Empty;

        /// <summary>
        /// The name of the stored procedure to update an entity.
        /// </summary>
        protected string StoredProcedureUpdate { get; set; } = string.Empty;

        /// <summary>
        /// The name of the stored procedure to delete an entity.
        /// </summary>
        protected string StoredProcedureDelete { get; set; } = string.Empty;

        public BaseDao()
        {
            _dbClient = new DbClient();
        }

        /// <inheritdoc/>
        public long Create(T entity)
        {
            IDictionary<string, object> parameters = entity.BuildInsert();
            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureInsert, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                return (long)dataTable.Rows[0][0];
            else
                return 0;
        }

        /// <inheritdoc/>
        public bool Delete(long id)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { BaseColumn.Id, id },
            };

            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureDelete, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /// <inheritdoc/>
        public bool Update(T entity)
        {
            IDictionary<string, object> parameters = entity.BuildUpdate();
            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureUpdate, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /// <inheritdoc/>
        public T? Get(long id)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { BaseColumn.Id, id },
            };

            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureGet, parameters);

            if (dataTable != null && dataTable.Rows.Count > 0)
                return dataTable.AsEnumerable().Select(ConvertDataRowToEntity).FirstOrDefault();
            else
                return null;
        }


        /// <inheritdoc/>
        public IEnumerable<T> List(IBaseFilter filter)
        {
            IDictionary<string, object> parameters = filter.BuildParams();

            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureList, parameters);


            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.AsEnumerable().Select(ConvertDataRowToEntity);
            }

            return Enumerable.Empty<T>();
        }

        /// <inheritdoc/>
        public IEnumerable<T> List(IBaseFilter filter, out long totalItems)
        {
            IDictionary<string, object> parameters = filter.BuildParams();

            DataTable dataTable = _dbClient.CallQueryStoredProcedure(StoredProcedureList, out totalItems, parameters);


            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.AsEnumerable().Select(ConvertDataRowToEntity);
            }

            return Enumerable.Empty<T>();
        }

        /// <summary>
        /// This method to convert data row to entity.
        /// </summary>
        /// <param name="dataRow">The data row</param>
        /// <returns></returns>
        public abstract T ConvertDataRowToEntity(DataRow dataRow);
    }
}
