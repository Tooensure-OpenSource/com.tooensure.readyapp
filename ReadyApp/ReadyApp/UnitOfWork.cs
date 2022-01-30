using ReadyApp.Services;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        // Not to sure if I can cast here, but will see
        public UnitOfWork()
        {
            Auth = (IAuthService)new AuthService();
        }
        public IAuthService Auth { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
