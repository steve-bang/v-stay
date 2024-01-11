namespace VStay_Backend.Models.Filters.Base
{
    /// <summary>
    /// This is the base class for all filters in the system.<br/>
    /// It is used to provide a common base class for all filters.
    /// </summary>
    public class BaseFilter : IBaseFilter
    {
        // Parameter Names
        public const string ParameterNameId = "ID";
        public const string ParameterNameModifiedBy = "Modified_By";
        public const string ParameterNameCreatedBy = "Created_By";
        public const string ParameterNamePageNumber = "Page_Number";
        public const string ParameterNamePageSize = "Page_Size";
        public const string ParameterNameSortDataField = "Sort_Data_Field";
        public const string ParameterNameSortOrder = "Sort_Order";
        public const string ParameterNameTotalRows = "Total_Rows";

        /// <summary>
        /// The Id param.
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// The Modified By param.
        /// </summary>
        public long? ModifiedBy { get; set; }

        /// <summary>
        /// The Created By param.
        /// </summary>
        public long? CreatedBy { get; set; }

        /// <summary>
        /// The Page Number param.
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// The Page Size param.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// The Sort Data Field param.
        /// </summary>
        public string SortDataField { get; set; } = string.Empty;

        /// <summary>
        /// The sort order param.
        /// </summary>
        public string SortOrder { get; set; } = string.Empty;

        /// <summary>
        /// Converts the filter to a dictionary of parameters.
        /// </summary>
        public virtual IDictionary<string, object> BuildParams()
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>();

            if(Id.HasValue)
                parameters.Add(ParameterNameId, Id.Value);

            if(ModifiedBy.HasValue)
                parameters.Add(ParameterNameModifiedBy, ModifiedBy.Value);

            if(CreatedBy.HasValue)
                parameters.Add(ParameterNameCreatedBy, CreatedBy.Value);

            if(!string.IsNullOrEmpty(SortDataField))
                parameters.Add(ParameterNameSortOrder, SortDataField);

            if(!string.IsNullOrEmpty(SortOrder))
                parameters.Add(ParameterNameTotalRows, SortOrder);

            return parameters;

        }

    }
}
