using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ZubMvvmc.Core
{
    public static class NavigationController
    {
        public static INavigation Navigation { get; set; }

        static NavigationController()
        {

        }
    }
}
