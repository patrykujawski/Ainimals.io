using Ainimals.io.Domain;

namespace Ainimals.io.Data;

public class Order
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public string PaymentId { get; set; }
    public DateTime CreatedAt { get; set; }
}