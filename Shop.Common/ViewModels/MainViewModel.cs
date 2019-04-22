namespace Shop.Common.ViewModels
{

    using System;
    using System.Collections.Generic;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;
    
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        readonly Type[] _menuItemTypes = {
            typeof(ProductsViewModel)
            //typeof(MySettingsViewModel),
        };

        public IEnumerable<string> MenuItems { get; private set; } = new[] { "Products"/*, "About"*/ };

        public void ShowDefaultMenuItem()
        {
            NavigateTo(0);
        }

        public void NavigateTo(int position)
        {
            //ShowViewModel(_menuItemTypes[position]);
            _navigationService.Navigate<ProductsViewModel>();
        }

    }


    public class MenuItem : Tuple<string, Type>
    {
        public MenuItem(string displayName, Type viewModelType)
            : base(displayName, viewModelType)
        { }

        public string DisplayName
        {
            get { return Item1; }
        }

        public Type ViewModelType
        {
            get { return Item2; }
        }
    }

}
