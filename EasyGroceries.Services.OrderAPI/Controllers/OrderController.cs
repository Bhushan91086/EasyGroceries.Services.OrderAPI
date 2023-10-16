using EasyGroceries.Order.Application.Contracts.Services;
using EasyGroceries.Order.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyGroceries.Services.OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetOrders")]
        public async Task<ActionResult<ResponseDto<OrderHeaderDto>>> Get(int userId)
        {
            var response = await _orderService.GetOrderByUserId(userId);
            if (response.Result == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost("CreateOrder")]
        public async Task<ActionResult<ResponseDto<OrderHeaderDto>>> CreateOrder([FromBody] CartDto cartDto)
        {
            var response = await _orderService.CreateOrder(cartDto);
            return Ok(response);
        }
    }
}
