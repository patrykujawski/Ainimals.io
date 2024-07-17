namespace Ainimals.io.PayNow.RefundState;

public interface IRefundState
{
    void Handle(RefundContext context);
}