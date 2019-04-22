using Android.OS;
using Android.Runtime;
using Android.Views;
using Shop.Common;
using Shop.Common.ViewModels;
using MvvmCross.Droid.Support.V4;
using Android.App;
using MvvmCross.Platforms.Android.Views;
//using MvvmCross.Droid.Views.Fragments;

namespace UICross.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class ProductsView : MvxActivity<ProductsViewModel>
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.ProductsPage);
        }


    }
}