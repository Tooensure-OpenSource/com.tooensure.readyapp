using ReadyApp.ViewModels;
using ReadyApp.Views;
using ReadyApp.Views.AuthView;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ReadyApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Authentifications
            Routing.RegisterRoute(nameof(AuthDetailPage), typeof(AuthDetailPage));
            Routing.RegisterRoute(nameof(AuthSignInPage), typeof(AuthSignInPage));
            Routing.RegisterRoute(nameof(AuthSignUpPage), typeof(AuthSignUpPage));


            // Examples
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
