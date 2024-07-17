using Ainimals.io.PayNow.PaymentState;

namespace Ainimals.io.PayNow;

public interface IPaymentState
{
    void Handle(PaymentContext context);
}