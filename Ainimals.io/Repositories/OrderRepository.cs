using Ainimals.io;
using Ainimals.io.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ainimals.Repositories;

public interface IOrderRepository
{
    Order GetOrderById(int orderId);
    void UpdateOrder(Order order);
    void SaveOrder(Order order);
}

public class OrderRepository : IOrderRepository
{
    // Implementacja operacji CRUD na bazie danych dla zamówień
    public Order GetOrderById(int orderId)
    {
        // Implementacja pobierania zamówienia z bazy danych
        throw new NotImplementedException();

    }

    public void UpdateOrder(Order order)
    {
        // Implementacja aktualizacji zamówienia w bazie danych
        throw new NotImplementedException();

    }

    public void SaveOrder(Order order)
    {
        // Implementacja zapisu zamówienia do bazy danych
        throw new NotImplementedException();
    }
}

