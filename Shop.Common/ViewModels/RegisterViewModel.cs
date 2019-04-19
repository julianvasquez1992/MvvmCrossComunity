using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Newtonsoft.Json;
using Shop.Common.Helpers;
using Shop.Common.Interfaces;
using Shop.Common.Models;
using Shop.Common.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Common.ViewModels
{
    public class RegisterViewModel : MvxViewModel
    {
        private readonly IApiService apiService;
        private readonly IMvxNavigationService navigationService;
        private readonly IDialogService dialogService;
        private List<Country> countries;


        public List<Country> Countries
        {
            get => this.countries;
            set
            {
                this.SetProperty(ref this.countries, value);
            }
        }

        public RegisterViewModel(IMvxNavigationService navigationService, IApiService apiService, IDialogService dialogService)
        {
            this.apiService = apiService;
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            this.LoadCountries();
        }

        private async void LoadCountries()
        {
            var response = await this.apiService.GetListAsync<Country>(
                "https://shopzulu.azurewebsites.net",
                "/api",
                "/Countries");

            if (!response.IsSuccess)
            {
                this.dialogService.Alert("Error", response.Message, "Accept");
                return;
            }

            var myCountries = (List<Country>)response.Result;
        }

    }
}
