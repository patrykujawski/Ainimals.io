using Ainimals.io;
using Ainimals.io.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ainimals.Repositories;

public interface IOrderRepository
{
    Task<Order?> GetOrder(string id);
    Task CreateFromDto(OrderDto orderDto);
    Task Add(string id, OrderDto order);
    Task<Order> Update(string id, OrderDto order);
}

public class OrderRepository(ApplicationDbContext context) : IOrderRepository
{
    public async Task<Order?> GetOrder(string id)
    {
        return await context.Orders.FindAsync(id);
    }

    public Task CreateFromDto(OrderDto orderDto)
    {
        throw new NotImplementedException();
    }

    public async Task Add(string id, OrderDto orderDto)
    {
        var order = await context.Orders.FindAsync(id);
        if (order is not null) throw new Exception("Nie dodaje bo juz istnieje");
        

        var newOrder = new Order
        {
            Id = id,
            PaymentStateId = orderDto.PaymentStateId,
            UserId = orderDto.UserId,
        };
        // czy przypadkiem order o takim id juz istnieje, jesli tak to rzucam exception [zaimplementować]
        // jesli nie ma to stworzyc nowy obiekt Order, nadac Id - Guid.NewGuid();
        // przekazac userId i paymentId z orderDto do nowej instacji ordera i zapisac w bazie przez context.Order.Add
        
        await context.Orders.AddAsync(newOrder);
        await context.SaveChangesAsync();
    }

    public async Task<Order> Update(string id, OrderDto orderDto)
    {
        var order = await context.Orders.FindAsync(id);
        if (order is null) throw new Exception();
        context.Orders.Update(order); 
        await context.SaveChangesAsync();
        return order;
    }
    

}


