using ChurchApp.ViewModels;
using CommonServiceLocator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        private readonly SettingsViewModel _viewModel;

        public LoginPage()
        {
            InitializeComponent();

            _viewModel = ServiceLocator.Current.GetInstance<SettingsViewModel>();

            BindingContext = _viewModel;
        }      

    }
}