using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class OrderService
    {
        private static IOrderService _order = DependencyService.Get<IOrderService>();

        public async Task<Order?> Delete(string id)
        {
            return await _order.Delete(id);
        }

        public async Task<Order?> Get(string id)
        {
            return await _order.Get(id);
        }

        public async Task<IEnumerable<Order>?> GetAll()
        {
            return await _order.GetAll();
        }

        public async Task<Order?> Update(Order model)
        {
            return await _order.Update(model);
        }
    }
}
