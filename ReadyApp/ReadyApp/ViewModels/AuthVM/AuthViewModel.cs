using ReadyApp.Models;
using ReadyApp.Types;
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
        private bool _isAuththenticated;
        private string? _email;
        private string? _password;
        private IUnitOfWork _unitOfWork { get; }

        public AuthType AuthType { get; set; }


        public Command? LoginWithReady { get; }
        public Command? LoginWithGoogle { get; }

        public AuthViewModel()
        {
            _unitOfWork = new UnitOfWork();
            LoginWithReady = new Command(OnSignInWithReady);
            LoginWithReady = new Command(OnSignInWithGoogle);
        }

        public string? Email
        {
            get { return _email; }
            set => SetProperty(ref _email, value);
        }
        public string? Password
        {
            get { return _password ; }
            set => SetProperty(ref _password, value);
        }

        private async void OnSignInWithReady(object obj)
        {
            _isAuththenticated = 
                await _unitOfWork.Auth.SignInWithReady(_email, _password);

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof()}");

        }
        private async void OnSignInWithGoogle(object obj)
        {
            _isAuththenticated = 
                await _unitOfWork.Auth.SignInWithGoogle();

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof()}");
        }
    }
}
