using Ainimals.io.PayNow;
using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io;

public class PendingPaymentState : IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("Your payment method was chosen , Paynow waiting to complete payment ");
        context.SetState(new ConfirmedPaymentState());
        context.SetState(new ErrorPaymentState());
        context.SetState(new ExpiredPaymentState());
        context.SetState(new RejectedPaymentState());
    }
}
