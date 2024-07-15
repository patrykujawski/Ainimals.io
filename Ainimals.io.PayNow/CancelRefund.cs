namespace Ainimals.io.PayNow;

public class CancelRefund
{
    public record PayLoad
    {
        
    }

    public record Response
    {
        public StatusCode StatusCode {get; set;}
        public IEnumerable<Error>Errors { get; set; }
    }
}