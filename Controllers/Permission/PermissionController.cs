using Microsoft.AspNetCore.Mvc;
using VStay_Backend.Models.Cores.Permission;
using VStay_Backend.Models.Filters.Implements;
using VStay_Backend.Models.Response;
using VStay_Backend.Models.Response.Base;
using VStay_Backend.Services;

namespace VStay_Backend.Controllers.Permission
{
    public class Routes
    {
        /// <summary>
        /// The base endpoints for the permission controller.
        /// </summary>
        public const string Base = "api/permissions";

        /// <summary>
        /// The URI to create a new permission - POST api/permissions
        /// </summary>
        public const string Create = "";

        /// <summary>
        /// The URI to gets the list of the permissions - GET api/permissions
        /// </summary>
        public const string List = "";

        /// <summary>
        /// The URI to gets a entity by the given id - GET api/permissions/{id}
        /// </summary>
        public const string GetById = "{id:long}";

        /// <summary>
        /// The URI to deletes a permission - DELETE api/permissions/{id}
        /// </summary>
        public const string DeleteById = "{id:long}";

        /// <summary>
        /// The URI to updates a permission - PUT api/permissions/{id}
        /// </summary>
        public const string UpdateById = "{id:long}";

    }

    [Route(Routes.Base)]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [Route(Routes.Create)]
        [HttpPost]
        public IActionResult Create([FromBody] CPermission permission)
        {
            ResponseApi responseApi = _permissionService.Create(permission);
            return StatusCode(responseApi.Code, responseApi);
        }


        [Route(Routes.List)]
        [HttpGet]
        public IActionResult List([FromQuery] PermissionFilter filter)
        {
            ResponseApi responseApi = _permissionService.ListPageble(filter);
            return StatusCode(responseApi.Code, responseApi);
        }


        [Route(Routes.GetById)]
        [HttpGet]
        public IActionResult GetById(long id)
        {
            ResponseApi responseApi = _permissionService.GetById(id);
            return StatusCode(responseApi.Code, responseApi);
        }

        [Route(Routes.UpdateById)]
        [HttpPut]
        public IActionResult UpdateById(long id, CPermission permission)
        {
            ResponseApi responseApi = _permissionService.Update(id, permission);
            return StatusCode(responseApi.Code, responseApi);
        }

        [Route(Routes.DeleteById)]
        [HttpDelete]
        public IActionResult DeleteById(long id)
        {
            ResponseApi responseApi = _permissionService.DeleteById(id);
            return StatusCode(responseApi.Code, responseApi);
        }

    }
}
