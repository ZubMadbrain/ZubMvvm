using System;
using System.Collections.Generic;
using System.Text;
using ZubMvvmc.Core;

namespace ZubMvvmc.Examples.Xamarin.Models
{
    public class Contact : Model
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        private string _mobileNumer;
        public string MobileNumber
        {
            get { return _mobileNumer; }
            set { _mobileNumer = value; OnPropertyChanged(nameof(MobileNumber)); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public Contact()
        {

        }
    }
}
