using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Shop.Common.ViewModels;

namespace UICross.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class ProductDetailView : MvxActivity<ProductsDetailViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.product_detail);
        }
    }
}