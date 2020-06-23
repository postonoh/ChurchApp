using ChurchApp.ViewModels;
using CommonServiceLocator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostOverviewPage : ContentPage
    {
        public PostOverviewPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<PostViewModel>();
            
        }
    }
}