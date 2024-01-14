using VStay_Backend.Models.Filters.Base;
using VStay_Backend.Models.Filters.Interfaces;

namespace VStay_Backend.Models.Filters.Implements
{
    /// <summary>
    /// This represents a filter for the Permissions in the system.
    /// </summary>
    public class PermissionFilter : BaseFilter ,IPermissionFilter
    {
        // Parameter Names
        public const string ParameterNameName = "Name";
        public const string ParameterNameDescription = "Description";

        /// <summary>
        /// The parameter name of the permission filter.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The parameter description of the permission filter.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <inheritdoc/>
        public override IDictionary<string, object> BuildParams()
        {
            // Calls the base class to get the base parameters.
            IDictionary<string, object> parameters = base.BuildParams();

            // Checks if the Name property is set and adds it to the parameters if it is.
            if (!string.IsNullOrEmpty(Name))
            {
                parameters.Add(ParameterNameName, Name);
            }

            // Checks if the Description property is set and adds it to the parameters if it is.
            if (!string.IsNullOrEmpty(Description))
            {
                parameters.Add(ParameterNameDescription, Description);
            }

            // Returns the parameters.
            return parameters;
        }

    }
}
