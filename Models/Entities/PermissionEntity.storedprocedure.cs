namespace VStay_Backend.Models.Entities
{
    public partial class PermissionEntity
    {
        /// <summary>
        /// The table name of the permission.
        /// </summary>
        public const string TableName = "Permission";

        /// <summary>
        /// The stored procedure insert.
        /// </summary>
        public const string StoredProcedureInsert = "usp_Permission_Insert";

        /// <summary>
        /// The stored procedure get by id.
        /// </summary>
        public const string StoredProcedureGet = "usp_Permission_Get";

        /// <summary>
        /// The stored procedure list.
        /// </summary>
        public const string StoredProcedureList = "usp_Permission_List";

        /// <summary>
        /// The stored procedure update.
        /// </summary>
        public const string StoredProcedureUpdate = "usp_Permission_Update";

        /// <summary>
        /// The stored procedure delete.
        /// </summary>
        public const string StoredProcedureDelete = "usp_Permission_Delete";


        public IDictionary<string, object> BuildInsert()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { Column.Name, Name ?? (object)DBNull.Value },
                { Column.Description, Description ?? (object)DBNull.Value },
                { Column.CreatedBy, CreatedBy ?? (object)DBNull.Value },
            };

            return parameters;
        }

        public IDictionary<string, object> BuildUpdate()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { Column.Id, Id },
                { Column.Name, Name ?? (object)DBNull.Value },
                { Column.Description, Description ?? (object)DBNull.Value },
                { Column.ModifiedBy, ModifiedBy ?? (object)DBNull.Value },
            };

            return parameters;
        }

    }
}
