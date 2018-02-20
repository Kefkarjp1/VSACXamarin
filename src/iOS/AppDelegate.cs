﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Push;

namespace VSACXamarin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

#if !DEBUG
            AppCenter.Start(Constants.VsacApiKey, typeof(Analytics), typeof(Crashes), typeof(Push));
#endif
                     

#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif

            return base.FinishedLaunching(uiApplication, launchOptions);
        }

        override didReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
        {
            var result = Push.DidReceiveRemoteNotification(userInfo);
            if (result)
            {
                completionHandler?.Invoke((UIBackgroundFetchResult.NewData));
            } else
            {
                completionHandler?.Invoke(UIBackgroundFetchResult.NoData);
            }

    }
}
