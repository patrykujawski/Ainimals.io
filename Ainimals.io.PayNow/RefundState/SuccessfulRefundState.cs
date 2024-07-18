namespace Ainimals.io.PayNow.RefundState;

public class SuccessfulRefundState:IRefundState
{
    public void Handle(RefundContext context)
    {
        Console.WriteLine("The refund has been successfully processed by Paynow and the money has been transferred to the buyer's account");
        context.SetState(new ConfirmedRefundState());
    }
}