﻿namespace Shop.Common.ViewModels
{
    using Helpers;
    using Interfaces;
    using Models;
    using MvvmCross.Commands;
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;
    using Newtonsoft.Json;
    using Services;
    using Shop.Common.Utilities;
    using System.Collections.Generic;
    using System.Windows.Input;

    public class ProductsViewModel : MvxViewModel
    {
        private List<Product> products;
        private readonly IApiService apiService;
        private readonly IDialogService dialogService;
        private readonly IMvxNavigationService navigationService;
        private MvxCommand addProductCommand;
        private MvxCommand<Product> itemClickCommand;

        //Simple ICommand interface implementation, simple click
        public ICommand ItemClickCommand
        {
            get
            {
                this.itemClickCommand = new MvxCommand<Product>(OnItemClickCommand);
                return itemClickCommand;
            }
             
        }

        public List<Product> Products
        {
            get => this.products;
            set => this.SetProperty(ref this.products, value);
        }

        public ICommand AddProductCommand
        {
            get
            {
                this.addProductCommand = this.addProductCommand ?? new MvxCommand(this.AddProduct);
                return this.addProductCommand;
            }
        }

        public ProductsViewModel(
            IApiService apiService,
            IDialogService dialogService,
            IMvxNavigationService navigationService)
        {
            this.apiService = apiService;
            this.dialogService = dialogService;
            this.navigationService = navigationService;
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
            var response = await this.apiService.GetListAsync<Product>(
                "https://shopzulu.azurewebsites.net",
                "/api",
                "/Products",
                "bearer",
                token.Token);

            if (!response.IsSuccess)
            {
                this.dialogService.Alert("Error", response.Message, "Accept");
                return;
            }

            this.Products = (List<Product>)response.Result;
        }

        private async void AddProduct()
        {
            await this.navigationService.Navigate<AppProductViewModel>();
        }

        //The method when the object was clicked
        private async void OnItemClickCommand(Product product)
        {
            await this.navigationService.Navigate<ProductsDetailViewModel, NavigationArgs>(new NavigationArgs { ProductId = product.Id });
        }
    }
}