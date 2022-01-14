using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private ICreateService _createService;

        public TaxController(ICreateService createService)
        {
            _createService = createService;
        }

        [HttpPost("CreateTax")]
        public IActionResult CreateTax(TaxDto.MvTax mvTax)
        {
            try
            {
                return Ok(_createService.CreateTax(mvTax));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

