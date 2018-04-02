using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvc.Examples.Xamarin.Views;
using ZubMvvmc.Controls;
using ZubMvvmc.Core;

namespace ZubMvvc.Examples.Xamarin.Controllers
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
