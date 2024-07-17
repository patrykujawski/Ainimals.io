namespace Ainimals.io.PayNow.RefundState;

public class RefundContext(IRefundState refundstate)
{
    public void SetState(IRefundState refundState)
    {
        refundstate = new NewRefundState();
    }
    
}