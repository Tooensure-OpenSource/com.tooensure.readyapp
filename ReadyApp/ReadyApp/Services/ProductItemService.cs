using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class ProductItemService
    {
        private static IProductItemService _productItem= DependencyService.Get<IProductItemService>();

        public async Task<ProductItem?> Delete(string id)
        {
            return await _productItem.Delete(id); 
        }

        public async Task<ProductItem?> Get(string id)
        {
            return await _productItem.Get(id);
        }

        public async Task<IEnumerable<ProductItem>?> GetAll()
        {
            return await _productItem.GetAll();
        }

        public async Task<ProductItem?> Update(ProductItem model)
        {
            return await _productItem.Update(model);
        }
    }
}
