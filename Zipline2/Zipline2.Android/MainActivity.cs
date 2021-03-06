﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Zipline2;
using CarouselView.FormsPlugin.Android;

namespace Zipline2.Droid
{
    [Activity(Label = "Zipline2", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            //Commented out because can't find Xamarin Insights Nuget package.
            //Insights.HasPendingCrashReport += (sender, isStartupCrash) =>
            //{
            //    if (isStartupCrash)
            //    {
            //        Insights.PurgePendingCrashReports().Wait();
            //    }
            //};
            //Insights.Initialize("Your API Key");

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //string dbPath = FileAccessHelper.GetLocalFilePath("orders.db3");

            //LoadApplication(new App(dbPath));
            LoadApplication(new App());
        }
    }
}

