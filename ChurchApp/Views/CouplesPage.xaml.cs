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
    }
}