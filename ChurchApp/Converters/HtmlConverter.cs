﻿using System;
using System.Globalization;
using System.Net;
using ChurchApp.Utility;
using Xamarin.Forms;

namespace ChurchApp.Converters
{
    public class HtmlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return HtmlTools.Strip(WebUtility.HtmlDecode(value.ToString()));
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                return WebUtility.HtmlEncode(value.ToString());
            }

            return string.Empty;
        }
    }
}
