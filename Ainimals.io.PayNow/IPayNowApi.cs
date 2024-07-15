using System.Data.Common;
using System.Runtime.Versioning;
using RestEase;

namespace Ainimals.io.PayNow;

public interface IPayNowApi

{
   
    [Post("/v1/payments")]
   Task<PaymentRequest.Response>  PaymentRequest([Body] PaymentRequest.Payload payload);


    
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