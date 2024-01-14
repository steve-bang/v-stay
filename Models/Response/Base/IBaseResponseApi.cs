namespace VStay_Backend.Models.Response.Base
{
    public interface IBaseResponseApi
    {
        /// <summary>
        /// Is the requests was success.
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// The code of the response.
        /// </summary>
        int Code { get; set; }

        /// <summary>
        /// The message of the response.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// The data of the response.
        /// </summary>
        object Data { get; }

        /// <summary>
        /// The date time to response.
        /// </summary>
        DateTime CreatedAt { get;}
    }
}
