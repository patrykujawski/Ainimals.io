using Ainimals.io.Domain;

namespace Ainimals.io.Data;

public class PaymentState
{
    public string PaymentId { get; set; }
    public PaymentStatus? PaymentStatus { get; set; }
}