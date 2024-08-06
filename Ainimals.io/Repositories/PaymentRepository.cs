using Ainimals.io.Data;

namespace Ainimals.Repositories;

public interface IPaymentRepository
{
    Payment GetPaymentById(string paymentId);
    void SavePayment(Payment payment);
    void UpdatePayment(Payment payment);
}

public class PaymentRepository : IPaymentRepository
{
    // Implementacja operacji CRUD na bazie danych dla płatności
    public Payment GetPaymentById(string paymentId)
    {
        // Implementacja pobierania płatności z bazy danych
        
        throw new NotImplementedException();
    }

    public void SavePayment(Payment payment)
    {
        // Implementacja zapisu płatności do bazy danych
        throw new NotImplementedException();
    }

    public void UpdatePayment(Payment payment)
    {
        // Implementacja aktualizacji płatności w bazie danych
        throw new NotImplementedException();
    }
}