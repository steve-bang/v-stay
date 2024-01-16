using System.Data;

namespace VStay_Backend.Models.Entities
{
    /// <summary>
    /// The role entity.
    /// </summary>
    public partial class RoleEntity : BaseEntity<RoleEntity>
    {
        public RoleEntity() : base () { }

        public RoleEntity(DataRow dataRow)
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

        }



        /// <summary>
        /// Parse the data row to role entity.
        /// </summary>
        /// <param name="dataRow">The data row object.</param>
        /// <returns>The role entity.</returns>
        public override RoleEntity ParseDataRow(DataRow dataRow)
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
