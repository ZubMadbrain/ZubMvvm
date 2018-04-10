using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Core;

namespace ZubMvvmc.Controls
{
    public class View : Xamarin.Forms.ContentView
    {
        public View()
        {
            BindingContext = new ViewModel();
        }
    }
}
