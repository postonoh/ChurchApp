﻿using ChurchApp.ViewModels;
using CommonServiceLocator;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChurchApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheQueenYouPage : ContentPage
    {
        public TheQueenYouPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance<QueenViewModel>();
        }
    }
}