using RestEase;

namespace Ainimals.io.PayNow.PayNowAPi;

public interface IPayNowApi
{
    [Post("/v1/payments")]
    Task<Payment.Response>  PaymentRequest([Body] Payment.Payload payload);
   
    [Get("/v1/payments/{paymentId}/status")]
    Task PaymentStatus([Path]string paymentId);
    [Get("/v2/payments/paymentmethods")]
    Task PaymentMethods();

    [Get("/v1/payments/dataprocessing/notices")]
    Task GetCDPRClauses();

    [Post("/v1/payments/{paymentId}/refunds")]
    Task<RefundRequest.Response> RefundRequest([Body] RefundRequest.PayLoad payLoad, [Path]string paymentId);

    [Get("/v1/refunds/{refundId}/status")]
    Task RefundStatus([Path]string refundId);

    [Post("/v1/refunds/{refundId}/cancel")]
    Task<RefundStatus.Response> CancelRefund([Path] string refundId);
}

public interface IPayNowClient
{
    Payment.Response CreatePayment(Payment.Payload request);
    // Inne metody np. sprawdzanie statusu płatności
}

public class PayNowClient : IPayNowClient
{
    private IPayNowApi _payNowApi = RestClient.For<IPayNowApi>("");

    public Payment.Response CreatePayment(Payment.Payload request)
    {
        // Implementacja wysyłania żądania do PayNow API
        throw new NotImplementedException();
    }
}