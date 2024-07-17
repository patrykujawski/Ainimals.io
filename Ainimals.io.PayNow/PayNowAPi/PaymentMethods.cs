namespace Ainimals.io.PayNow.PayNowAPi;

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