using VStay_Backend.Models.Filters.Base;

namespace VStay_Backend.Models.Filters.Interfaces
{
    /// <summary>
    /// This defines the interface for the PerissionFilter class.<br/>
    /// It is used to filter the Citys in the system.
    /// </summary>
    public interface IPermissionFilter : IBaseFilter
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
