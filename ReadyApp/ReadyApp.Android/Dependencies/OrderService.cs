using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.OrderService))]
namespace ReadyApp.Droid.Dependencies
{
    public class OrderService : IOrderService
    {
        public Task<Order> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Order> Update(Order model)
        {
            throw new NotImplementedException();
        }
    }
}