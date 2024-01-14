using System.Data;

namespace VStay_Backend.Models.Entities
{
    /// <summary>
    /// This is the base class for all entities in the system.<br/>
    /// It is used to provide a common base class for all entities.
    /// </summary>
    public abstract class BaseEntity<T> : IBaseEntity<T, long>
    {
        /// <inheritdoc/>
        public long Id { get; set; }

        /// <inheritdoc/>
        public long? ModifiedBy { get; set; }

        /// <inheritdoc/>
        public DateTime? ModifiedDate { get; set; }

        /// <inheritdoc/>
        public long? CreatedBy { get; set; }

        /// <inheritdoc/>
        public DateTime? CreatedDate { get; set; }

        /// <inheritdoc/>
        public abstract T ParseDataRow(DataRow dataRow);

        /// <inheritdoc/>
        public abstract IDictionary<string, object> BuildInsert();

        /// <inheritdoc/>
        public abstract IDictionary<string, object> BuildUpdate();

    }

    /// <summary>
    /// This is the base column class for all entities in the system.
    /// </summary>
    public class BaseColumn
    {
        /// <summary>
        /// Maps to the name of column [ID] in the table.
        /// </summary>
        public const string Id = "ID";

        /// <summary>
        /// Maps to the name of column [Modified_By] in the table.
        /// </summary>
        public const string ModifiedBy = "Modified_By";

        /// <summary>
        /// Maps to the name of column [Modified_Date] in the table.
        /// </summary>
        public const string ModifiedDate = "Modified_Date";

        /// <summary>
        /// Maps to the name of column [Created_By] in the table.
        /// </summary>
        public const string CreatedBy = "Created_By";

        /// <summary>
        /// Maps to the name of column [Created_Date] in the table.
        /// </summary>
        public const string CreateDate = "Created_Date";
    }
}
