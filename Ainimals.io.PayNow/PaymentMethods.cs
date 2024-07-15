namespace Ainimals.io.PayNow;

public class PaymentMethods
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public string Type { get; set; }
        public string PaymentMethods { get; set; }
        
    }
}