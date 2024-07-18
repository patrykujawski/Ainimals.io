namespace Ainimals.io.PayNow.PayNowAPi;

public class RefundRequest
{
    public record PayLoad
    {
        public string Amount { get; set; }
        public string Reason { get; set; }
    }

    public record Response
    {
        public string RefoundId { get; set; }
        public StatusCode StatusCode {get;set;}
        public IEnumerable<Error>Errors { get; set; }
    }
}