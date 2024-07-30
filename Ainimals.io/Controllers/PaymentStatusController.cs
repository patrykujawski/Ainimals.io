using Ainimals.io.Data;
using Ainimals.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ainimals.io.Controllers;

[Route("payments")]
public class PaymentStatusController(IPaymentStatusRepository paymentStatusRepository) : Controller
{

    [HttpGet("{:id}")]
    public async Task<IActionResult> GetPaymentStatus([FromRoute] string id)
    {
        var paymentStatus = await paymentStatusRepository.GetPaymentStatus(id);
        return Ok(paymentStatus);
    }

    [HttpPost("add-payment-status")]
    public async Task<IActionResult> AddPaymentStatus([FromBody] PaymentStateDto paymentStateDto)
    {
        if (paymentStateDto == null)
        {
            return BadRequest("Payment status is null");
        }

        return Ok(paymentStateDto);

    }
    [HttpDelete("{:id}")]

    public async Task<IActionResult> DeletePaymentState([FromRoute] string id)
    {
        var deletePaymentState = await paymentStatusRepository.Delete(id);
        return Ok(deletePaymentState);
    }
}