using Android.OS;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;

namespace UICross.Android.Views
{
    public class AboutFrag : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.About, container, false);
        }
    }
}