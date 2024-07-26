using Ainimals.io.Domain;

namespace Ainimals.io.Data;

public class PaymentState
{
    public string Id { get; set; }
    public string OrderId { get; set; }
    public Order Order { get; set; }
    public PaymentStatus State { get; set; }
}