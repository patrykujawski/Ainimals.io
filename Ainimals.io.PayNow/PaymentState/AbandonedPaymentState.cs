using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public class AbandonedPaymentState:IPaymentState
{
    public void Handle(PaymentContext context)
    {
        context.SetState( );
    }
}