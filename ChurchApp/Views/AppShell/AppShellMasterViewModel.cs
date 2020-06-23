using ChurchApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WordPressPCL.Models;
using WordPressPCL.Utility;

namespace ChurchApp.Views.AppShell
{
    public class AppShellMasterViewModel
    {


        public ObservableCollection<AppShellMenuItem> PrimaryMenuItems { get; set; }

     
        public AppShellMasterViewModel()
        {
            PrimaryMenuItems = new ObservableCollection<AppShellMenuItem>(new[]
            {
                new AppShellMenuItem { Id = 0, Title = "Home Page", TargetType = typeof(MainPage) },
                new AppShellMenuItem { Id = 1, Title = "All Ministries", TargetType = typeof(PostOverviewPage) },
                new AppShellMenuItem { Id = 2, Title = "The King in You", TargetType = typeof(TheKingInYouPage) },
                new AppShellMenuItem { Id = 3, Title = "The Queen in You", TargetType = typeof(TheQueenYouPage) },
                new AppShellMenuItem { Id = 4, Title = "Couple Ministry", TargetType = typeof(CouplesPage) },
                new AppShellMenuItem { Id = 5, Title = "Singles Ministry", TargetType = typeof(SinglesPage) },
                new AppShellMenuItem { Id = 6, Title = "Login", TargetType= typeof(LoginPage)},
            });

        }      
    }
}