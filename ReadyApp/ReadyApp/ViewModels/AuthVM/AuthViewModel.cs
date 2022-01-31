using ReadyApp.Models;
using ReadyApp.Types;
using ReadyApp.Views.AuthView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.ViewModels.AuthVM
{
    public class AuthViewModel : BaseViewModel
    {
        private AuthType _authType { get; set; }

        public AuthViewModel()
        {
        }
        public async void Instance(AuthType authType)
        {
            IsBusy = true;
            _authType = authType;
            if (authType.Equals(AuthType.ready)) await OnSignInWithReady();
            if (authType.Equals(AuthType.google)) await OnSignInWithGoogle();
        }

        public async Task<bool> OnSignInWithReady()
        {
            IsBusy = true;
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AuthSignInPage)}");
            return IsBusy;
        }
        public async Task<bool> OnSignInWithGoogle()
        {
            IsBusy= true;
            //var user = await _unitOfWork.Auth.SignInWithGoogle();
            //return _isAuththenticated = user != null;
            await Shell.Current.GoToAsync($"{nameof(AuthDetailPage)}?{nameof(AuthDetailViewModel.AuthType)}={_authType.ToString()}");

            //await Shell.Current.GoToAsync($"//{nameof(AuthDetailPage)}");
            return IsBusy;
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof()}");
        }
    }
}
