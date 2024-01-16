namespace VStay_Backend.Models.Entities
{
    public partial class RoleEntity
    {
        /// <summary>
        /// The name of the role.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of the role.
        /// </summary>
        public string Description { get; set; } = string.Empty;


        /// <summary>
        /// This class is include all column for Role table.
        /// </summary>
        public class Column : BaseColumn
        {
            public const string Name = "Name";

            public const string Description = "Description";

        }
    }
}
