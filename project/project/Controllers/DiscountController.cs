using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private ICreateService _createService;

        public DiscountController(ICreateService createService)
        {
            _createService = createService;
        }

        [HttpPost("CreateDiscount")]
        public IActionResult CreateDiscount(DiscountDto.MvDiscount mvDiscount)
        {
            try
            {
                return Ok(_createService.CreateDiscount(mvDiscount));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}
