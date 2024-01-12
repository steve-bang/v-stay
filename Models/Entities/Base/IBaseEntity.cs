using System.Data;

namespace VStay_Backend.Models.Entities
{
    /// <summary>
    /// This is the base interface for all entities in the system.  
    /// It is used to provide a common base interface for all entities.
    /// </summary>
    public interface IBaseEntity<T, ID>
    {
        /// <summary>
        /// The id of the entity.
        /// </summary>
        ID Id { get; set; }

        /// <summary>
        /// The modified by of the entity.
        /// </summary>
        long? ModifiedBy { get; set; }

        /// <summary>
        /// The modified date of the entity.
        /// </summary>
        DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The created by of the entity.
        /// </summary>
        long? CreatedBy { get; set; }

        /// <summary>
        /// The created date of the entity.
        /// </summary>
        DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Parses the data row and returns a new entity with the parsed values.
        /// </summary>
        /// <param name="dataRow">The data row to parse.</param>
        /// <param name="hasTableNamePrefix">If the column names have a table name prefix.</param>
        /// <returns>The instance of the entity.</returns>
        T ParseDataRow(DataRow dataRow);

    }
}
