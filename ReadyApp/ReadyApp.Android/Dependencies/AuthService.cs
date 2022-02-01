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

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.AuthService))]
namespace ReadyApp.Droid.Dependencies
{
    public class AuthService : Java.Lang.Object, IAuthService
    {
        public Task<User> SignInAnonymously()
        {
            throw new NotImplementedException();
        }

        public Task<User> SignInWithGoogle()
        {
            throw new NotImplementedException();
        }

        public Task<User> SignInWithReady(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}