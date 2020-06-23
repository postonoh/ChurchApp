using ChurchApp.Interfaces;
using ChurchApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ChurchApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        private readonly WordpressService _wordpressService;

        private int _menuTitle = -1;

        public HomeViewModel(WordpressService wordpressService)
        {
            _wordpressService = wordpressService;
        }


    }

}
