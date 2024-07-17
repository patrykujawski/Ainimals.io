namespace Ainimals.io.PayNow.PayNowAPi;

public class PaymentRequest
{
    public record Payload
    {
        public int Amount { get; set; }
        public string Description { get; set; }

        public IEnumerable<Buyer>Buyers { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public string PaymentMethodId { get; set; }
    }

    public record Buyer
    {
        public string Email { get; set; }
        public int Phone { get; set; }
    }

    public record OrderItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public record Response
    {
        public string RedirectUrl { get; set; }
        public string PaymentId { get; set; }
        public StatusCode StatusCode {  get; set; }
        public IEnumerable<Error>Errors { get; set; }
    }
   

}