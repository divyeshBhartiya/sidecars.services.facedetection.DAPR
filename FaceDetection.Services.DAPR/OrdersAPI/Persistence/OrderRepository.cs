﻿using Microsoft.EntityFrameworkCore;
using OrdersAPI.Models;
using System;
using System.Threading.Tasks;

namespace OrdersAPI.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersContext _context;

        public OrderRepository(OrdersContext context)
        {
            _context = context;
        }
        public async Task<Order> GetOrderAsync(Guid id)
        {
            return await _context.Orders.Include("OrderDetails").FirstOrDefaultAsync(c => c.OrderId == id);
        }

        public async Task RegisterOrder(Order order)
        {
            _context.Add(order);
            await _context.SaveChangesAsync();
        }

        //public async  Task UpdateOrder(Order order)
        //{
        //    _context.Entry(order).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //}
    }
}
