namespace ThressWays.FormsCross.iOS
{
    using Foundation;
    using MvvmCross.Forms.Platforms.Ios.Core;
    using ThreeWays.Core;
    using UIKit;

    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<App, FormsApp>, App, FormsApp>
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}