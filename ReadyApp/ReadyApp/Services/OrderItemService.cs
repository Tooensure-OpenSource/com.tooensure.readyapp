using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class OrderItemService : IOrderItemService
    {
        private static IOrderItemService _orderItem = DependencyService.Get<IOrderItemService>();

        public async Task<OrderItem?> Delete(string id)
        {
            return await _orderItem.Delete(id);
        }

        public async Task<OrderItem?> Get(string id)
        {
            return await _orderItem.Get(id);
        }

        public async Task<IEnumerable<OrderItem>?> GetAll()
        {
            return await _orderItem.GetAll();
        }

        public async Task<OrderItem?> Update(OrderItem model)
        {
            return await _orderItem.Update(model);
        }
    }
}
