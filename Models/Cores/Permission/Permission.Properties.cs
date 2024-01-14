namespace VStay_Backend.Models.Cores.Permission
{
    public partial class CPermission
    {
        /// <summary>
        /// The id of the permission.
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// The name of the permission.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of the permission.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The mofidied by of the permission.
        /// </summary>
        public long? ModifiedBy { get; set; }

        /// <summary>
        /// The modified date of the permission.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The created by of the permission.
        /// </summary>
        public long? CreatedBy { get; set; }

        /// <summary>
        /// The created date of the permission.
        /// </summary>
        public DateTime? CreatedDate { get; set; }


    }
}
