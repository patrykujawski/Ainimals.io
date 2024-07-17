namespace Ainimals.io.PayNow.PayNowAPi;

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