using Ainimals.io.Domain;

namespace Ainimals.io.Data;

public class Order
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public PaymentStatus? PaymentStatus { get; set; }
}