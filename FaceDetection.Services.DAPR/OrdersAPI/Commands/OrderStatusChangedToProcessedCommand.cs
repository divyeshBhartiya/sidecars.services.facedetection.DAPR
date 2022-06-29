using System;
using System.Collections.Generic;

namespace OrdersAPI.Commands
{
    public class OrderStatusChangedToProcessedCommand
    {
        public Guid OrderId { get; set; }
        public List<byte[]> Faces { get; set; }
    }
}
