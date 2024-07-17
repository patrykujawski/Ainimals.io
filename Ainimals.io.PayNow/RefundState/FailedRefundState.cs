namespace Ainimals.io.PayNow.RefundState;

public class FailedRefundState: IRefundState
{
    public void Handle(RefundContext context)
    {
        Console.WriteLine("Your return encountered a problem while processing. The money has not been transferred to the buyer");
        context.SetState(new ConfirmedRefundState());
    }
}