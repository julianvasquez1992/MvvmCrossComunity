namespace UICross.Android.Views
{
    using global::Android.App;
    using global::Android.OS;
    using global::Android.Support.V7.Widget;
    using MvvmCross.Droid.Support.V7.AppCompat;
    using MvvmCross.Platforms.Android.Views;
    using Shop.Common.ViewModels;

    [Activity(Label = "@string/app_name")]
    public class KittensView : MvxActivity<ProductsViewModel>
    {
        //private Toolbar toolbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.LoginPage);
            //toolbar = FindViewById<Toolbar>(Resource.Id.toolbar_cross);
            //this.SetSupportActionBar(toolbar);
        }
    }
}