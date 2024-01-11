namespace VStay_Backend.Models.Filters.Base
{
    /// <summary>
    /// This is the base interface for all filters in the system.<br/>
    /// </summary>
    public interface IBaseFilter
    {
        /// <summary>
        /// The @ID param.
        /// </summary>
        long? Id { get; set; }

        /// <summary>
        /// The @Modified_By param.
        /// </summary>
        long? ModifiedBy { get; set; }

        /// <summary>
        /// The @Created_By param.
        /// </summary>
        long? CreatedBy { get; set; }

        /// <summary>
        /// The @Page_Number param.
        /// </summary>
        int? PageNumber { get; set; }

        /// <summary>
        /// The @Page_Size param.
        /// </summary>
        int? PageSize { get; set; }

        /// <summary>
        /// The @Sort_Data_Field param.
        /// </summary>
        string SortDataField { get; set; }
        
        /// <summary>
        /// The @Sort_Order param.
        /// </summary>
        string SortOrder { get; set; }

        /// <summary>
        /// Builds the parameters.
        /// </summary>
        /// <returns>The Dictionay with parameter.</returns>
        IDictionary<string, object> BuildParams();

    }
}
