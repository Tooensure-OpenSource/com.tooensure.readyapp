using ReadyApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Services.IService
{
    public interface IAuthService
    {
        Task<bool> SignInWithReady(string? email, string? password);
        Task<bool> SignInWithGoogle();
        Task<bool> SignInAnonymously();
    }
}
