namespace Ainimals.io.Data;

public class Payment
{
    public int Id { get; set; }
    public string PaymentId { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Description { get; set; }
}