using ReadyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Services.IService
{
    public interface IAuthService
    {
        Task<User?> SignInWithReady(string? email, string? password);
        Task<User?> SignInWithGoogle();
        Task<User?> SignInAnonymously();
    }
}
