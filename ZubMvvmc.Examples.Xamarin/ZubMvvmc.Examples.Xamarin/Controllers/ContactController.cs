using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Examples.Xamarin.Views;
using ZubMvvmc.Controls;
using ZubMvvmc.Core;

namespace ZubMvvmc.Examples.Xamarin.Controllers
{
    public class ContactController : Controller
    {
        public override View GetObjectsView()
        {
            return new ContactView();
        }

        public override View GetObjectView()
        {
            return new ContactsView();
        }
    }
}
