using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class ProductService : IProductService
    {
        private static IProductService _product = DependencyService.Get<IProductService>();

        public async Task<Product?> Delete(string id)
        {
            return await _product.Delete(id);
        }

        public async Task<Product?> Get(string id)
        {
            return await _product.Get(id);
        }

        public async Task<IEnumerable<Product>?> GetAll()
        {
            return await _product.GetAll();
        }

        public async Task<Product?> Update(Product model)
        {
            return await _product.Update(model);
        }
    }
}
