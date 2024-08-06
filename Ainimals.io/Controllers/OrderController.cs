using Ainimals.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Ainimals.io.Controllers;

[Route("orders")]
public class OrderController(IOrderRepository orderRepository) : Controller
{
    [HttpGet("{:id}")]
    public async Task<IActionResult> GetOrder(string id) 
    {
        var order = await orderRepository.GetOrder(id);
        return Ok(order);
    }

    [HttpPost("test-order")]
    public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
    {
        if (string.IsNullOrWhiteSpace(orderDto.PaymentStateId) || string.IsNullOrWhiteSpace(orderDto.UserId))
        {
            return BadRequest();
        }
        return Ok(orderDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AddOrder([FromRoute] string id, [FromBody] OrderDto orderDto)
    {
        await orderRepository.Add(id, orderDto);
        return Ok();
        
    }
}