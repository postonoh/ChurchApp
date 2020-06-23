
using WordPressPCL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views.AppShell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellMaster : ContentPage
    {
        public ListView PrimaryListView { get; set; }
        public AppShellMaster()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                IconImageSource = "Icon.png";

            BindingContext = new AppShellMasterViewModel();

            PrimaryListView = Primary;
        }
    }
}