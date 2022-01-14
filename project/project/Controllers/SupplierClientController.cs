using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierClientController : ControllerBase
    {
        private ICreateService _createService;

        public SupplierClientController(ICreateService createService)
        {
            _createService = createService;
        }


        [HttpPost("CreateSupplierClient")]
        public IActionResult CreateSupplierClient(SupplierClientDto.MvSupplierClient mvSupplierClient)
        {
            try
            {
                return Ok(_createService.CreateSupplierClient(mvSupplierClient));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}
