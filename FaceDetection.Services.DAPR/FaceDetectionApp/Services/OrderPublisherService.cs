using Dapr.Client;
using FaceDetectionApp.Events;
using FaceDetectionApp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace FaceDetectionApp.Services
{
    public static class OrderPublisherService
    {
        public static async Task OrderPublishAsync(OrderReceivedEvent orderReceivedEvent, DaprClient daprClient, ILogger logger)
        {
            try
            {
                await daprClient.PublishEventAsync("eventbus", "OrderReceivedEvent", orderReceivedEvent);
                logger.LogInformation("Publishing event: OrderReceivedEvent, OrderId:  {orderId}", orderReceivedEvent.OrderId);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "ERROR Publishing event: orderReceivedEvent: OrderId: {orderId}", orderReceivedEvent.OrderId);
                throw;
            }
        }
    }
}
