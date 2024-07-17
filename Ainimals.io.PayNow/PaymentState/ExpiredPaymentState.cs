using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public class ExpiredPaymentState: IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("Validity time has passed and the payment is no longer possible");
     //   context.SetState(new ConfirmedPaymentState());// zakonczenie chyba nie confirmed
    }
}