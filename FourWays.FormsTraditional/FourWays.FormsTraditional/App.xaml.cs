namespace FourWays.FormsTraditional
{
    using Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new TipPage());
        }
    }
}