namespace Ainimals.io.PayNow;

public record Error
{
    public string ErrorType { get; set; }
    public string Message { get; set; }
}