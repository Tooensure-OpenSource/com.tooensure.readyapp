using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class BusinessService
    {
        private static IBusinessService _business = DependencyService.Get<IBusinessService>();

        public async Task<Business?> Delete(string id)
        {
            return await _business.Delete(id);
        }

        public async Task<Business?> Get(string id)
        {
            return await _business.Delete(id);
        }

        public async Task<IEnumerable<Business>?> GetAll()
        {
            return await _business.GetAll();
        }

        public async Task<Business?> Update(Business model)
        {
           return await _business.Update(model);
        }
    }
}
