/**
 * The response api to client for all api.
 */
namespace VStay_Backend.Models.Response
{
    /// <summary>
    /// This class is used when to return the data for client request.
    /// </summary>
    /// <typeparam name="T">The type of the data.</typeparam>
    public class ResponseApi <T>
    {
        /// <summary>
        /// This message is use to return when the request was success.
        /// </summary>
        public const string MessageSuccess = "The request wass successfull.";

        /// <summary>
        /// Is the requests was success.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The message of the response.
        /// </summary>
        public string Message { get; set; } = MessageSuccess;

        /// <summary>
        /// The code of the response.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The data of the response.
        /// </summary>
        public T? Data;

    }
}
