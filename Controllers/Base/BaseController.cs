using Microsoft.AspNetCore.Mvc;
using VStay_Backend.Models.Response.Base;

namespace VStay_Backend.Controllers.Base
{
    /// <summary>
    /// This controller is the base controller for all controllers.
    /// </summary>
    [ApiController]
    // Specify the route prefix for the controller.
    // [Route("api/v{version:apiVersion}/[controller]")]
    // Specify the base (or current) API route to:
    // - Keep the existing route serving a default version (backward compatible).
    // - Support query string and HTTP header versioning.
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        /// Converts the API result to the action result.
        /// </summary>
        /// <param name="baseResponseApi">The API result.</param>
        /// <returns>The action result.</returns>
        public IActionResult ReturnApiResult(IBaseResponseApi baseResponseApi)
        {
            return StatusCode(baseResponseApi.Code, baseResponseApi);
        }
    }
}
