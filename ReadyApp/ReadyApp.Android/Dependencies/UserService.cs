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

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.UserService))]
namespace ReadyApp.Droid.Dependencies
{
    public class UserService : Java.Lang.Object, IUserService
    {
        public Task<User> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}