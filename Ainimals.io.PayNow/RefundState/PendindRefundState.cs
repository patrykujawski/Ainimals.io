namespace Ainimals.io.PayNow.RefundState;

public class PendindRefundState:IRefundState
{
    public void Handle(RefundContext context)
    {
        Console.WriteLine("Paynow began the decision to release.");
        context.SetState(new SuccessfulRefundState());
        context.SetState(new FailedRefundState());
    }

}