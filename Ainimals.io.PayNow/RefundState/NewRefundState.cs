namespace Ainimals.io.PayNow.RefundState;

public class NewRefundState : IRefundState
{
    public void Handle(RefundContext context)
    {
        Console.WriteLine("Your refund was accepted");
        context.SetState(new PendindRefundState());
        context.SetState(new CancelledRefundState());
    }
}

