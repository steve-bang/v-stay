namespace VStay_Backend.Models.Filters.Interfaces
{
    /// <summary>
    /// This defines the interface for the RoleFilter class.<br/>
    /// It is used to filter the Roles in the system.
    /// </summary>
    public interface IRoleFilter
    {
        /// <summary>
        /// Gets or sets the @Name parameter value.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the @Description parameter value.
        /// </summary>
        string Description { get; set; }
    }
}
