namespace UICross.Android.Services
{
    using global::Android.App;
    using MvvmCross;
    using MvvmCross.Platforms.Android;
    using Shop.Common.Interfaces;

    public class DialogService : IDialogService
    {
        public void Alert(string title, string message, string okbtnText)
        {
            var top = Mvx.Resolve<IMvxAndroidCurrentTopActivity>();
            var act = top.Activity;

            var adb = new AlertDialog.Builder(act);
            adb.SetTitle(title);
            adb.SetMessage(message);
            adb.SetPositiveButton(okbtnText, (sender, args) => { /* some logic */ });
            adb.Create().Show();
        }
    }
}