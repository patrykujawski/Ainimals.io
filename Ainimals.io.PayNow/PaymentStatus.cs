namespace Ainimals.io.PayNow;

public class PaymentStatus
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public string PaymentId { get; set; }
        public StatusCode StatusCode{get; set; }

        public IEnumerable<Error> Errors { get; set; }
       

    }
}