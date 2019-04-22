namespace UICross.Android
{
    using MvvmCross;
    using MvvmCross.Platforms.Android.Core;
    using MvvmCross.Platforms.Android.Presenters;
    using Services;
    using Shop.Common;
    using Shop.Common.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using MvvmCross.Droid.Support.V7.AppCompat;
    using global::Android.Content;

    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            Mvx.IoCProvider.RegisterType<IDialogService, DialogService>();

            base.InitializeFirstChance();
        }

        public override IEnumerable<Assembly> GetPluginAssemblies()
        {
            var assemblies = base.GetPluginAssemblies().ToList();
            assemblies.Add(typeof(MvvmCross.Plugin.Visibility.Platforms.Android.Plugin).Assembly);
            return assemblies;
        }

        //public Setup(Context applicationContext)
        //    : base(applicationContext)
        //{
        //}

        //protected override IMvxApplication CreateApp()
        //{
        //    return new App();
        //}

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
        {
            typeof(global::Android.Support.V7.Widget.Toolbar).Assembly,
        };

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxFragmentsPresenter = new MvxAppCompatViewPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter); //TO DO: Review this method
            return mvxFragmentsPresenter;
        }

    }
}