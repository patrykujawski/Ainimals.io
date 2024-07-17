namespace Ainimals.io.PayNow.PaymentState;

public class PaymentContext(IPaymentState state)
{
    public void SetState(IPaymentState paymentState)
    {
        state = new io.PaymentState();
    }
}