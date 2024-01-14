namespace VStay_Backend.Models.Response.Base
{
    /// <summary>
    /// This is base reponse api class for API.
    /// </summary>
    public class BaseResponseApi : IBaseResponseApi
    {
        /// <inheritdoc/>
        public bool Success { get; set; } = true;

        /// <inheritdoc/>
        public int Code { get; set; } = 200;

        /// <inheritdoc/>
        public const string MessageSuccess = "The request wass successfull.";

        /// <inheritdoc/>
        public string Message { get; set; } = MessageSuccess;

        /// <inheritdoc/>
        public object Data { get; } = new object();


        /// <inheritdoc/>
        public DateTime CreatedAt { get; } = DateTime.UtcNow;

        public BaseResponseApi(object data)
        {
            Data = data;
        }
    }
}
