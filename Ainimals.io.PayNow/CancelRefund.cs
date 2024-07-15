namespace Ainimals.io.PayNow;

public class CancelRefund
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public enum StatusCode {get;set;}
        public IEnumerable<PaymentRequest.Error>Errors { get; set; }
    }
}