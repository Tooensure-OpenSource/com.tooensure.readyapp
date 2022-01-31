using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class FavoriteService
    {
        private static IFavoriteService _favorite = DependencyService.Get<IFavoriteService>();

        public async Task<Favorite?> Delete(string id)
        {
            return await _favorite.Delete(id);  
        }

        public async Task<Favorite?> Get(string id)
        {
            return await _favorite.Get(id);
        }

        public async Task<IEnumerable<Favorite>?> GetAll()
        {
            return await _favorite.GetAll();
        }

        public Task<Favorite?> Update(Favorite model)
        {
            return _favorite.Update(model);
        }
    }
}
