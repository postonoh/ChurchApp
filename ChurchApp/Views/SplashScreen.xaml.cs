using ChurchApp.ViewModels;
using ChurchApp.Views.AppShell;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        private readonly SettingsViewModel _viewModel;
      
        public SplashScreen()
        {
            InitializeComponent();

            _viewModel = ServiceLocator.Current.GetInstance<SettingsViewModel>();
            BindingContext = _viewModel;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            
            // try to autologin
            await ServiceLocator.Current.GetInstance<SettingsViewModel>().TryAutoLoginCommand.ExecuteAsync();

            await _viewModel.TryAutoLogin();

            var loggedin = _viewModel.IsLoggingIn;

            if (loggedin)
            {
                Application.Current.MainPage = new AppShellPage();
            }
            else
            {
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}