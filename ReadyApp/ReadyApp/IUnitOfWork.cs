using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp
{
    public interface IUnitOfWork
    {
        IAuthService Auth { get; set; }
    }
}
