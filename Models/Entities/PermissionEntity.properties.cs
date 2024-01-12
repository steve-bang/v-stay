namespace VStay_Backend.Models.Entities
{
    /// <summary>
    /// The permission entity.
    /// </summary>
    public partial class PermissionEntity : BaseEntity<PermissionEntity>
    {
        /// <summary>
        /// The name of the permission.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of the permission.
        /// </summary>
        public string Description { get; set; } = string.Empty;



        /// <summary>
        /// This class is include all column for Permisson table.
        /// </summary>
        public class Column : BaseColumn
        {
            public const string Name = "Name";

            public const string Description = "Description";

        }
    }
}
