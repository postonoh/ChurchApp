using ChurchApp.ViewModels;
using CommonServiceLocator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheKingInYouPage : ContentPage
    {

        private readonly KingViewModel _viewModel;

        public TheKingInYouPage()
        {
            InitializeComponent();
            _viewModel = ServiceLocator.Current.GetInstance<KingViewModel>();

            BindingContext = _viewModel;
        }        
    }
}