using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using ZubMvvmc.Core;

namespace ZubMvvmc.Examples.Xamarin.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

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
        }
    }
}
