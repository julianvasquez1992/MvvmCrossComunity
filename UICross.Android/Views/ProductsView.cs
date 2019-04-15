using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using Shop.Common.ViewModels;

namespace UICross.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class ProductsView : MvxActivity<ProductsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.ProductsPage);
            //toolbar = FindViewById<Toolbar>(Resource.Id.toolbar_cross);
            //this.SetSupportActionBar(toolbar);
        }
    }
}