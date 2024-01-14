namespace VStay_Backend.Models.Entities
{
    public partial class PermissionEntity
    {
        /// <summary>
        /// The table name of the permission.
        /// </summary>
        public const string TableName = "Permission";

        public IDictionary<string, object> BuildGetId()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { Column.Id, Id },
            };

            return parameters;
        }

        /// <inheritdoc/>
        public override IDictionary<string, object> BuildInsert()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { Column.Name, Name ?? (object)DBNull.Value },
                { Column.Description, Description ?? (object)DBNull.Value },
                { Column.CreatedBy, CreatedBy ?? (object)DBNull.Value },
            };

            return parameters;
        }

        /// <inheritdoc/>
        public override IDictionary<string, object> BuildUpdate()
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
