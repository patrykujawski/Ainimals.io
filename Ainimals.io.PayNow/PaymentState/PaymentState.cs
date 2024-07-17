using Ainimals.io.PayNow;
using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io;

public class PaymentState : IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("Please select payment method");
        context.SetState(new PendingPaymentState());
        context.SetState(new ErrorPaymentState());
        context.SetState(new ExpiredPaymentState());
        context.SetState(new AbandonedPaymentState());
    }
    

}