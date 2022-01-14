using Microsoft.AspNetCore.Mvc;
using project.Dto;
using project.Services;
using System;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private ICreateService _createService;

        public SalesOrderController(ICreateService createService)
        {
            _createService = createService;
        }


        [HttpPost("CreateSalesOrder")]
        public IActionResult CreateSalesOrder(SalesOrderDto.MvSalesOrder mvSalesOrder)
        {
            try
            {
                return Ok(_createService.CreateSalesOrder(mvSalesOrder));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}
