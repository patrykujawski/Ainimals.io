using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public class ConfirmedPaymentState: IPaymentState
{
    public void Handle(PaymentContext context)
    {
        Console.WriteLine("The payment has been successfully processed by Paynow");
        context.SetState(new io.PaymentState());

    }
    
}