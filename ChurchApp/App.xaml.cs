using ChurchApp.Init;
using ChurchApp.Views;
using Com.OneSignal;
using Com.OneSignal.Abstractions;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChurchApp
{
    public partial class App : Application
    {

    

        public App()
        {
            InitializeComponent();

            Bootstrapper.RegisterDependencies();


            MainPage = new SplashScreen();


            OneSignal.Current.StartInit("05ee1b6c-6324-4fa5-b9c9-1f1754750bec")
            .Settings(new Dictionary<string, bool>() {
            { IOSSettings.kOSSettingsKeyAutoPrompt, false },
            { IOSSettings.kOSSettingsKeyInAppLaunchURL, false } })
            .InFocusDisplaying(OSInFocusDisplayOption.Notification)
            .EndInit();


            OneSignal.Current.RegisterForPushNotifications();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
