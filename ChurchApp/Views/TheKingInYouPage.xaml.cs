using ChurchApp.ViewModels;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheKingInYouPage : ContentPage
    {
       
        public TheKingInYouPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<KingViewModel>();
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ServiceLocator.Current.GetInstance<KingViewModel>().LoadPostsAsyncCommand.ExecuteAsync();
            
        }
    }
}