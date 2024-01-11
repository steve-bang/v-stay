using Microsoft.AspNetCore.Mvc;

namespace VStay_Backend.Controllers.User
{
    public class Route
    {
        /// <summary>
        /// The base endpoints for the user controller.
        /// </summary>
        public const string Base = "api/users";

        /// <summary>
        /// The URI to register a user - POST api/users/register
        /// </summary>
        public const string Register = "register";

        /// <summary>
        /// The URI to authentication user - POST api/users/authentication
        /// </summary>
        public const string Authentication = "authentication";

    }

    [Route(Route.Base)]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Register a new user.
        /// </summary>
        /// <returns>The user after register success.</returns>
        [Route(Route.Register)]
        [HttpPost]
        public IActionResult Register()
        {
            return Ok(new {message = "Register user success"});
        }

        /// <summary>
        /// Authentication user.
        /// </summary>
        /// <returns>The user after register success.</returns>
        [Route(Route.Authentication)]
        [HttpPost]
        public IActionResult Authentication()
        {
            return Ok(new { message = "Authentication user success" });
        }

    }
}
