using Ainimals.io.Payments;
using Ainimals.io.PayNow.PayNowAPi;
using Microsoft.AspNetCore.Mvc;

namespace Ainimals.io.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController(IPaymentService paymentService) : ControllerBase
{
    [HttpPost("create")]
    public IActionResult CreatePayment([FromBody] int orderId)
    {
        try
        {
            var redirectUrl = paymentService.CreatePayment(orderId);
            return Ok(new { RedirectUrl = redirectUrl });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpPost("notification")]
    public IActionResult HandleNotification([FromBody] Payment.Notification notification)
    {
        try
        {
            paymentService.HandlePaymentNotification(notification.PaymentId, notification.Status);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }
}