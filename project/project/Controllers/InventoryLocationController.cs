using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryLocationController : ControllerBase
    {
        private ICreateService _createService;

        public InventoryLocationController(ICreateService createService)
        {
            _createService = createService;
        }

        [HttpPost("CreateInventoryLocation")]
        public IActionResult CreateInventoryLocation(InventoryLocationDto.MvInventoryLocation mvInventoryLocation)
        {
            try
            {
                return Ok(_createService.CreateInventoryLocation(mvInventoryLocation));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}
