
using VStay_Backend.Models.Response.Base;
/**
* The response api to client for all api.
*/
namespace VStay_Backend.Models.Response
{
    /// <summary>
    /// This class is used when to return the data for client request.
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    public class ResponseApi : BaseResponseApi
    {

        public ResponseApi(object data) : base(data) { }

    }

    /// <summary>
    /// The error class while throw exception to client.
    /// </summary>
    public class CError
    {
        /// <summary>
        /// The model code error while work with model.
        /// </summary>
        public int ModelCode { get; set; }

        /// <summary>
        /// The message error.
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}
