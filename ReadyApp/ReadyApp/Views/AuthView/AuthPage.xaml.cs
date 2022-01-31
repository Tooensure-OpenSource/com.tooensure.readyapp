using ReadyApp.Types;
using ReadyApp.ViewModels.AuthVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadyApp.Views.AuthView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        AuthViewModel _viewModel;

        private AuthType _authType { get; set; }
        public AuthPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AuthViewModel();
            _authType = AuthType.none;
            AnimateInit();
        }

        private void OnLoadInWithReady(object sender, EventArgs args)
        {
            _authType = AuthType.ready;
            AnimateStart();
        }
        private void OnLogInWithGoogle(object sender, EventArgs args)
        {
            _authType = AuthType.google;
            AnimateStart();
        }
        private async void AnimateStart()
        {
            if (_authType.Equals(AuthType.ready))
            {
                await animateBtn.TranslateTo(0, 3, 150, Easing.SinInOut);
                await animateBtn.TranslateTo(0, 0, 150, Easing.SinIn);
            }
            else
            {
                await googleAnimateBtn.TranslateTo(0, 3, 150, Easing.SinInOut);
                await googleAnimateBtn.TranslateTo(0, 0, 150, Easing.SinIn);
            }

            TextBarAnimate();
        }
        private async void AnimateEnd()
        {
            if (_authType.Equals(AuthType.ready))
            {
                await logoBtn.RotateTo(5, 500, Easing.SinOut);
                await logoBtn.RotateTo(-5, 500, Easing.SinIn);

                await logoBtn.RotateTo(0, 500, Easing.SinIn);
            }
            else
            {
                await googleLogoBtn.RotateTo(5, 500, Easing.SinOut);
                await googleLogoBtn.RotateTo(-5, 500, Easing.SinIn);

                await googleLogoBtn.RotateTo(0, 500, Easing.SinIn);
            }
        }

        private async void TextBarAnimate()
        {

            if (_authType.Equals(AuthType.ready))
            {
                await textBar.TranslateTo(0, 0, 500, Easing.BounceOut);

                await googleAnimateBtn.FadeTo(.0, 500, Easing.SinIn);
                await animateBtn.FadeTo(.0, 500, Easing.SinIn);

                _viewModel.Instance(_authType);
            }
            else
            {
                await googleTextBar.TranslateTo(0, 0, 1000, Easing.BounceOut);

                await animateBtn.FadeTo(.0, 500, Easing.SinIn);
                await googleAnimateBtn.FadeTo(.0, 1000, Easing.SinIn);
                _viewModel.Instance(_authType);
                //await _viewModel.OnSignInWithGoogle();

            }
            AnimateInit();

        }

        private async void AnimateInit()
        {
            if (_authType.Equals(AuthType.ready))
            {
                await animateBtn.FadeTo(1, 1000, Easing.SinIn);
                await googleAnimateBtn.FadeTo(1, 1000, Easing.SinIn);

                await textBar.TranslateTo(70, 0, 500, Easing.BounceOut);
            }
            else if (_authType.Equals(AuthType.google))
            {
                await animateBtn.FadeTo(1, 1000, Easing.SinIn);
                await googleAnimateBtn.FadeTo(1, 1000, Easing.SinIn);

                await googleTextBar.TranslateTo(70, 0, 500, Easing.BounceOut);
            }
            else
            {
                await animateBtn.FadeTo(1, 500, Easing.SinIn);
                await textBar.TranslateTo(70, 0, 500, Easing.BounceOut);

                await googleAnimateBtn.FadeTo(1, 500, Easing.SinIn);
                await googleTextBar.TranslateTo(70, 0, 500, Easing.BounceOut);
            }

        }
    }
}