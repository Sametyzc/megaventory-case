using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ICreateService _createService;

        public ProductController(ICreateService createService)
        {
            _createService = createService;
        }


        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(ProductDto.MvProduct mvProduct)
        {
            try
            {
                return Ok(_createService.CreateProduct(mvProduct));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}
