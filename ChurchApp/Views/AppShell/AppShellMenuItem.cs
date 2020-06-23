using System;
using System.Data.Common;

namespace ChurchApp.Views.AppShell
{
    public class AppShellMenuItem
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}