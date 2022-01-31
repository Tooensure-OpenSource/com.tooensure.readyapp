using ReadyApp.Models;
using ReadyApp.Services.IService;
using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class AuthService
    {
        private static IAuthService _auth = DependencyService.Get<IAuthService>();

        public async Task<User?> SignInWithReady(string? email, string? password)
        {
            return await _auth.SignInWithReady(email, password);
        }
        public async Task<User?> SignInWithGoogle()
        {
            return await _auth.SignInWithGoogle();
        }
        public async Task<User?> SignInAnonymously()
        {
            return await _auth.SignInAnonymously();
        }
    }
}
