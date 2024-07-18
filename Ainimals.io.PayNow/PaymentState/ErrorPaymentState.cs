using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public class ErrorPaymentState: IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine(" Problem occurred during the payment process");
        context.SetState(new ConfirmedPaymentState());
        context.SetState(new AbandonedPaymentState());
        context.SetState(new ConfirmedPaymentState());// zakonczony

    }
}