namespace Shop.Common.ViewModels
{
    using MvvmCross.Navigation;
    using MvvmCross.ViewModels;
    using Newtonsoft.Json;
    using Shop.Common.Helpers;
    using Shop.Common.Models;
    using Shop.Common.Services;
    using Shop.Common.Utilities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductsDetailViewModel : MvxViewModel<NavigationArgs>
    {
        private readonly IMvxNavigationService navigationService;
        private readonly IApiService apiService;
        private int productId;
        public ProductsDetailViewModel(
            IMvxNavigationService navigationService,
            IApiService apiService)
        {
            this.navigationService = navigationService;
            this.apiService = apiService;
        }

        public async override void Prepare(NavigationArgs parameter)
        {
            this.productId = parameter.ProductId;
            Product product = await this.LoadProduct() as Product;
        }

        private async Task<Product> LoadProduct()
        {
            var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
            var response = await this.apiService.GetListAsync<Product>(
                "https://shopzulu.azurewebsites.net",
                "/api",
                "/Products",
                "bearer",
                token.Token);

            List<Product> products = (List<Product>)response.Result;

            return products.FirstOrDefault(x => x.Id == productId);
        }
    }
}
