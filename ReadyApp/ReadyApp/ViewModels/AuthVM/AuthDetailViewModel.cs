using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.ViewModels.AuthVM
{
    [QueryProperty(nameof(AuthType), nameof(AuthType))]
    public class AuthDetailViewModel : BaseViewModel
    {
        private bool _isAuththenticated;
        private UnitOfWork _unitOfWork { get; }


        private string AuthTypeText;
        private Types.AuthType _authType { get; } = new Types.AuthType();
        public AuthDetailViewModel()
        {
            _unitOfWork = new UnitOfWork();

            _authType = Types.AuthType.none;
            Func<Types.AuthType, Task<bool>> google = async (authType) =>
            {
               
                //if (authType.go.Equals("")) return await SignInWithGoogle();
                return false;
            };
        }
        public string AuthType
        {
            get
            {
                return AuthTypeText;
            }
            set
            {
                AuthTypeText = value;

                Func<Task<bool>> google = async () =>
                {
                    if (_authType.google.Equals("")) return await SignInWithGoogle();
                    return false;
                };
                google();
            }
            

        }

        private async Task<bool> SignInWithGoogle()
        {
            IsBusy = true;

            var user = await _unitOfWork.Auth.SignInWithGoogle();
            return _isAuththenticated = user != null;
        }
    }
}
