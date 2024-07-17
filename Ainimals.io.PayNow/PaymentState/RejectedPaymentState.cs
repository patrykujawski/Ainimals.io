using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public class RejectedPaymentState : IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("The payment was not authorized by the buyer. ");
        context.SetState(new ConfirmedPaymentState());
    }
}