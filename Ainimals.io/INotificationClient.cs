using Ainimals.io.ImagineAPI;
using Microsoft.AspNetCore.SignalR;

namespace Ainimals.io;

public interface INotificationClient

    {
        Task ReceiveNotification(Payload message);
    }
    public class NotificationHub : Hub<INotificationClient>
    {
    }
