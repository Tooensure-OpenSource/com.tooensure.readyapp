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

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.OrderItemService))]
namespace ReadyApp.Droid.Dependencies
{
    public class OrderItemService : Java.Lang.Object, IOrderItemService
    {
        public Task<OrderItem> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> Update(OrderItem model)
        {
            throw new NotImplementedException();
        }
    }
}