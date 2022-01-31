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
    public partial class AuthDetailPage : ContentPage
    {
        AuthDetailViewModel _viewModel;
        public AuthDetailPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AuthDetailViewModel();
        }
    }
}