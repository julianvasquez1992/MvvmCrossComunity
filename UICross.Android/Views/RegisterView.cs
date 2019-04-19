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
    public class RegisterView : MvxActivity<RegisterViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.register_page);
        }
    }
}