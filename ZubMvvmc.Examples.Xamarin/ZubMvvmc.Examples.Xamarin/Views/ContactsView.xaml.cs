using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZubMvvmc.Examples.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsView : ZubMvvmc.Controls.ObjectsView
    {
		public ContactsView ()
		{
			InitializeComponent ();
		}
	}
}