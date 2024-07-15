using System.Data.Common;
using System.Runtime.Versioning;
using RestEase;

namespace Ainimals.io.PayNow;

public interface IPayNowApi

{
   
    [Post("/v1/payments")]
   Task  PaymentRequest();


    
    [Get("/v1/payments/{paymentId}/status")]
    Task PaymentStatus();


    [Get("/v2/payments/paymentmethods")]
    Task PaymentMethods();

    [Get("/v1/payments/dataprocessing/notices")]
    Task GetCDPRClauses();

    [Post("/v1/payments/{paymentId}/refunds")]
    Task RefundRequest();

    [Get("/v1/refunds/{refundId}/status")]
    Task RefundStatus();

    [Post("/v1/refunds/{refundId}/cancel")]
    Task CancelRefund();

}