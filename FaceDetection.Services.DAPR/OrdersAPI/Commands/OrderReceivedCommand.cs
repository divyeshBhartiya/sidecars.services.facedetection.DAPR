using System;

namespace OrdersAPI.Commands
{
    public class OrderReceivedCommand
    {
        public Guid OrderId { get; set; }
        public string PhotoUrl { get; set; }
        public string UserEmail { get; set; }
        public byte[] ImageData { get; set; }
    }
}
