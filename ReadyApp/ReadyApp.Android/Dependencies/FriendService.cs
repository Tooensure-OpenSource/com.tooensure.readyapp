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

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.FriendService))]
namespace ReadyApp.Droid.Dependencies
{
    public class FriendService : Java.Lang.Object, IFriendService
    {
        public Task<Friend> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Friend> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Friend>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Friend> Update(Friend model)
        {
            throw new NotImplementedException();
        }
    }
}