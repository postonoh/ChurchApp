
using ChurchApp.ViewModels;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinglesPage : ContentPage
    {
        public SinglesPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<SinglesViewModel>();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ServiceLocator.Current.GetInstance<SinglesViewModel>().LoadPostsAsyncCommand.ExecuteAsync();

        }
    }
}