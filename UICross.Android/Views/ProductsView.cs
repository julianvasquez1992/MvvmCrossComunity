using MvvmCross.Droid.Support.V7.AppCompat;
using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Shop.Common.ViewModels;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Fragment = Android.Support.V4.App.Fragment;

namespace UICross.Android.Views
{
    

    [Activity(Label = "@string/app_name")]
    public class ProductsView : MvxAppCompatActivity<ProductsViewModel>
    {

        Fragment[] _fragments = { new AboutFrag(), new SettingsFrag() };

        string[] _titles = { "Option 1", "Option 2" };

        ActionBarDrawerToggle _drawerToggle;

        ListView _drawerListView;

        DrawerLayout _drawerLayout;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.ProductsPage);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);


            _drawerListView = FindViewById<ListView>(Resource.Id.drawerListView);
            _drawerListView.ItemClick += (s, e) => ShowFragmentAt(e.Position);
            _drawerListView.Adapter = new ArrayAdapter<string>(this, global::Android.Resource.Layout.SimpleListItem1, _titles);

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);

            _drawerToggle = new ActionBarDrawerToggle(this, _drawerLayout, Resource.String.OpenDrawerString, Resource.String.CloseDrawerString);

            _drawerLayout.SetDrawerListener(_drawerToggle);

            ShowFragmentAt(0);
        }


        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            //_drawerToggle.SyncState();

            base.OnPostCreate(savedInstanceState);
        }

        void ShowFragmentAt(int position)
        {
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.frameLayout, _fragments[position]).Commit();

            Title = _titles[position];

            _drawerLayout.CloseDrawer(_drawerListView);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (_drawerToggle.OnOptionsItemSelected(item))
                return true;

            return base.OnOptionsItemSelected(item);
        }

    }
}