using ChurchApp.ViewModels;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CouplesPage : ContentPage
    {
        public CouplesPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<CouplesViewModel>();
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ServiceLocator.Current.GetInstance<CouplesViewModel>().LoadPostsAsyncCommand.ExecuteAsync();

        }
    }
}