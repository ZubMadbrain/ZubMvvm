using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ZubMvvmc.Core;
using ZubMvvmc.Examples.Xamarin.Controllers;
using ZubMvvmc.Examples.Xamarin.Models;

namespace ZubMvvmc.Examples.Xamarin.PageViewModels
{
    public class MainPageViewModel : ViewModel
    {
        public Command ShowContactsCommand { get; set; }

        public MainPageViewModel()
        {
            ShowContactsCommand = new Command(ShowContacts);
        }

        public void ShowContacts()
        {
            ObservableCollection<Model> contacts = new ObservableCollection<Model>()
            {
                new Contact()
                {
                    Name = "Zub Madbrain",
                    Address = "6 Dungeonroad, Fire Mountain",
                    Email = "zubmadbrain@firemountain.com",
                    MobileNumber = "+012345678910"
                },
                new Contact()
                {
                    Name = "Buz Niarbdam",
                    Address = "103 Dungeonroad, Fire Mountain",
                    Email = "buzniarbdam@firemountain.com",
                    MobileNumber = "+109876543210"
                }
            };
            

            Controller contactController = new ContactController();
            contactController.Show(contacts, true);
        }
    }
}
