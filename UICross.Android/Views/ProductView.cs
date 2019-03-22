namespace UICross.Android.Views
{
    using global::Android.App;
    using global::Android.OS;
    using MvvmCross.Platforms.Android.Views;
    using Shop.Common.ViewModels;

    [Activity(Label = "@string/app_name")]
    public class KittensView : MvxActivity<ProductsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.ProductsPage);
        }
    }
}