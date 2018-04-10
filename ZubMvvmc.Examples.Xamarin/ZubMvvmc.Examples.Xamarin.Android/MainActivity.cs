using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZubMvvmc.Core;
using System.Threading.Tasks;

namespace ZubMvvmc.Examples.Xamarin.Droid
{
    [Activity(Label = "ZubMvvmc.Examples.Xamarin", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                try
                {
                    Exception ex = e.ExceptionObject as Exception;
                    if (ex != null)
                        InsightsWrapper.ReportException(ex);
                }
                catch (Exception ex)
                {
                    InsightsWrapper.ReportException(ex);
                }
            };


            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                InsightsWrapper.ReportException(e.Exception);
            };

            AndroidEnvironment.UnhandledExceptionRaiser += (sender, e) =>
            {
                InsightsWrapper.ReportException(e.Exception);
            };
        }
    }
}

