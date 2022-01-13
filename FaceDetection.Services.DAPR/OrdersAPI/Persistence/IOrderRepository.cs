using OrdersAPI.Models;
using System;
using System.Threading.Tasks;

namespace OrdersAPI.Persistence
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync(Guid id);
        public Task RegisterOrder(Order order);
        //public Task UpdateOrder(Order order);
    }
}
