 using System.Collections.Specialized;
 using Ainimals.io;
 using Ainimals.io.Data;
 using Ainimals.io.Domain;

 namespace Ainimals.Repositories;

public interface IPaymentStatusRepository
{
    Task<PaymentState?> GetPaymentStatus(string id);
    Task<PaymentState> Add( PaymentStateDto paymentState);
    Task<PaymentState> Update(string id, PaymentStateDto paymentState);
    Task<PaymentState> Delete(string id);
}



public  class PaymentStatusRepository(ApplicationDbContext context) : IPaymentStatusRepository
{
    public async Task<PaymentState?> GetPaymentStatus(string id)
    {
        return await context.PaymentState.FindAsync(id);

    }

    public async Task<PaymentState> Add(PaymentStateDto paymentState)
    {

        
        var newState = new PaymentState
        {
            Id = Guid.NewGuid().ToString(),
            OrderId = Guid.NewGuid().ToString(),
            State = PaymentStatus.New
        };
        await context.PaymentState.AddAsync(newState);
        await context.SaveChangesAsync();

        return newState;
    }

    public async Task<PaymentState> Update(string id, PaymentStateDto paymentState)
    {
        var state = await context.PaymentState.FindAsync(id);
        if (state is null) throw new Exception();
        context.PaymentState.Update(state);
        await context.SaveChangesAsync();
        return state;
    }

    public async Task<PaymentState> Delete(string id)
    {
        var state = await context.PaymentState.FindAsync(id);
        if (state is null) throw new Exception();
        context.PaymentState.Remove(state);
        await context.SaveChangesAsync();
        return state;
    }
}