using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ZubMvvmc.Core;
using ZubMvvmc.Examples.Xamarin.Controllers;
using ZubMvvmc.Examples.Xamarin.Models;

namespace ZubMvvmc.Examples.Xamarin.ViewModels
{
    public class ContactsViewModel : ObjectsViewModel
    {
        public Command ItemTappedCommand { get; set; }

        public ContactsViewModel(ObservableCollection<Model> models) : base(models)
        {
            ItemTappedCommand = new Command(ShowContact);
        }

        public void ShowContact(object parameter)
        {
            Contact contact = (Contact)parameter;
            ContactController contactController = new ContactController();
            contactController.Show(contact, true);
        }
    }
}
