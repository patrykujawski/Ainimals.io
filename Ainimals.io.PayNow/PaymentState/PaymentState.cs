using Ainimals.io.PayNow;
using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io;

public class PaymentState : IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("Please select payment method");
        context.SetState(new PendingPaymentState());
    }
    

}