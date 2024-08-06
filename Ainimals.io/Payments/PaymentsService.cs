using Ainimals.io.PayNow.PayNowAPi;
using Ainimals.Repositories;
using Payment = Ainimals.io.Data.Payment;

namespace Ainimals.io.Payments;

public interface IPaymentService
{
    string CreatePayment(int orderId);
    void HandlePaymentNotification(string paymentId, string status);
}

public class PaymentService(
    IOrderRepository orderRepository,
    IPaymentRepository paymentRepository,
    IPayNowClient payNowClient)
    : IPaymentService
{
    // Klient PayNow do realizacji żądań do API
    public string CreatePayment(int orderId)
    {
        var order = orderRepository.GetOrderById(orderId);
        if (order == null || order.Status != "Pending")
        {
            throw new InvalidOperationException("Order is invalid or not pending");
        }

        // Tworzenie płatności za pomocą PayNow API
        var paymentRequest = new Payment
        {
            Amount = order.Amount,
            OrderId = order.Id,
            Description = $"Order #{order.Id} payment"
            // Pozostałe wymagane pola
        };

        var paymentResponse = payNowClient.CreatePayment(new PayNow.PayNowAPi.Payment.Payload());

        // Zapisanie płatności w bazie danych
        var payment = new Payment
        {
            PaymentId = paymentResponse.PaymentId,
            OrderId = order.Id,
            Amount = order.Amount,
            Status = "Pending",
            CreatedAt = DateTime.UtcNow
        };
        paymentRepository.SavePayment(payment);

        // Aktualizacja zamówienia
        order.PaymentId = payment.PaymentId;
        orderRepository.UpdateOrder(order);

        return paymentResponse.RedirectUrl;
    }

    public void HandlePaymentNotification(string paymentId, string status)
    {
        var payment = paymentRepository.GetPaymentById(paymentId);
        if (payment == null)
        {
            throw new InvalidOperationException("Payment not found");
        }

        payment.Status = status;
        paymentRepository.UpdatePayment(payment);

        var order = orderRepository.GetOrderById(payment.OrderId);
        if (order != null)
        {
            order.Status = status == "CONFIRMED" ? "Completed" : "Failed";
            orderRepository.UpdateOrder(order);
        }
    }
}
