using Ainimals.io.ImagineAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Ainimals.io;

public static class ImagineWebhook
{
    public static void AddImagineApiWebhook(this WebApplication app)
    {
        app.MapPost("/webhook/image/",
            async ([FromBody] WebhookResponse response, IWebhookNotifier webhookNotifier) => await webhookNotifier.ImageGenerated(response));
    }
}

internal interface IWebhookNotifier
{
    Task ImageGenerated(WebhookResponse imageId);
}


internal class WebhookNotifier : IWebhookNotifier
{
    private readonly IHubContext<NotificationHub, INotificationClient> _hubContext;

    public WebhookNotifier(IHubContext<NotificationHub, INotificationClient> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task ImageGenerated(WebhookResponse imageId)
    {
        await _hubContext.Clients.All.ReceiveNotification(imageId.Payload);
    }
}
    
