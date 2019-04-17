using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.OS;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;

namespace UICross.Android.Views
{
    public class SettingsFrag : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Settings, container, false);
        }
    }
}