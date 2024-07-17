namespace Ainimals.io.PayNow.PayNowAPi;

public record Error
{
    public string ErrorType { get; set; }
    public string Message { get; set; }
}