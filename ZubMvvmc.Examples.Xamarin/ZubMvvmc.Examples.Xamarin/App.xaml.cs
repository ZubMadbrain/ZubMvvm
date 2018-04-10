using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using ZubMvvmc.Core;
using ZubMvvmc.Examples.Xamarin.PageViewModels;

namespace ZubMvvmc.Examples.Xamarin
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            ZubMvvmc.Controls.Page mainPage = new ZubMvvmc.Examples.Xamarin.Pages.MainPage();
            mainPage.BindingContext = new MainPageViewModel();

            MainPage = new NavigationPage(mainPage);
            NavigationController.Navigation = MainPage.Navigation;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
