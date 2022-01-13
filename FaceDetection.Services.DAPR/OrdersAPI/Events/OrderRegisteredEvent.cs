using System;

namespace OrdersAPI.Events
{
    public class OrderRegisteredEvent
    {
        public Guid OrderId { get; set; }
        public string UserEmail { get; set; }
        public byte[] ImageData { get; set; }
    }
}
