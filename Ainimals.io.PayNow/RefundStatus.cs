namespace Ainimals.io.PayNow;

public class RefundStatus
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public string RefoundId { get; set; }
        public StatusCode StatusCode {get;set;}
    }
}