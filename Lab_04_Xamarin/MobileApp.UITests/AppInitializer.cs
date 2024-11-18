using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MobileApp.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp("pl.dakil.mobileapp").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}