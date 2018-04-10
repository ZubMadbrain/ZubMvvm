using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Examples.Xamarin.Views;
using ZubMvvmc.Controls;
using ZubMvvmc.Core;
using ZubMvvmc.Examples.Xamarin.ViewModels;
using System.Collections.ObjectModel;

namespace ZubMvvmc.Examples.Xamarin.Controllers
{
    public class ContactController : Controller
    {
        protected override View GetObjectView(Model model)
        {
            return new ContactView() { BindingContext = new ContactViewModel(model) };
        }

        protected override View GetObjectsView(ObservableCollection<Model> models)
        {
            return new ContactsView() { BindingContext = new ContactsViewModel(models) };
        }

        //public override Page GetObjectPage()
        //{
        //    return new ContactsView();
        //}

        //public override Page GetObjectsPage()
        //{
        //    return new ContactsView();
        //}
    }
}
