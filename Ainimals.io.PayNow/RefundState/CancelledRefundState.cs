namespace Ainimals.io.PayNow.RefundState;

public class CancelledRefundState:IRefundState
{
    public void Handle(RefundContext context)
    {
        Console.WriteLine("The gate has been canceled. The money was not transferred to the buyer");
        context.SetState(new NewRefundState());
    }
}