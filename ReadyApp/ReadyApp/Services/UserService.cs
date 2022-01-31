using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class UserService 
    {
        private static IUserService _user = DependencyService.Get<IUserService>();

        public async Task<User?> Delete(string id)
        {
            return await _user.Delete(id);
        }

        public async Task<User?> Get(string id)
        {
            return await _user.Get(id);
        }

        public async Task<IEnumerable<User>?> GetAll()
        {
            return await _user.GetAll();
        }

        public async Task<User?> Update(User model)
        {
            return await _user.Update(model); 
        }
    }
}
