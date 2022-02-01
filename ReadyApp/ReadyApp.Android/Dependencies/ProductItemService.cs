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

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.ProductItemService))]
namespace ReadyApp.Droid.Dependencies
{
    public class ProductItemService : Java.Lang.Object, IProductItemService
    {
        public Task<ProductItem> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductItem> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductItem> Update(ProductItem model)
        {
            throw new NotImplementedException();
        }
    }
}