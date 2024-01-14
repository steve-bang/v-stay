using System.Data;

namespace VStay_Backend.Models.Entities
{
    /// <summary>
    /// The permission entity.
    /// </summary>
    public partial class PermissionEntity : BaseEntity<PermissionEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        public PermissionEntity() : base() { }

        /// <summary>
        /// Parse the data row to permission entity.
        /// </summary>
        /// <param name="dataRow">The data row object.</param>
        /// <returns>The permission entity.</returns>
        public PermissionEntity (DataRow dataRow)
        {
            try
            {
                Id = dataRow.Field<long>(BaseColumn.Id);
                Name = dataRow.Field<string>(Column.Name);
                Description = dataRow.Field<string>(Column.Description);
                ModifiedBy = dataRow.Field<long?>(BaseColumn.ModifiedBy);
                ModifiedDate = dataRow.Field<DateTime>(BaseColumn.ModifiedDate);
                CreatedBy = dataRow.Field<long?>(BaseColumn.CreatedBy);
                CreatedDate = dataRow.Field<DateTime>(BaseColumn.CreateDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when parse to permission entity, details {ex.Message}");
            }
        }

        /// <summary>
        /// Parse the data row to permission entity.
        /// </summary>
        /// <param name="dataRow">The data row object.</param>
        /// <returns>The permission entity.</returns>
        public override PermissionEntity ParseDataRow(DataRow dataRow)
        {
            try
            {
                Id = dataRow.Field<long>(BaseColumn.Id);
                Name = dataRow.Field<string>(Column.Name);
                Description = dataRow.Field<string>(Column.Description);
                ModifiedBy = dataRow.Field<long?>(BaseColumn.ModifiedBy);
                ModifiedDate = dataRow.Field<DateTime>(BaseColumn.ModifiedDate);
                CreatedBy = dataRow.Field<long?>(BaseColumn.CreatedBy);
                CreatedDate = dataRow.Field<DateTime>(BaseColumn.CreateDate);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when parse to permission entity, details {ex.Message}");
                throw new Exception(ex.Message);
            }

            return this;

        }
    }
}
