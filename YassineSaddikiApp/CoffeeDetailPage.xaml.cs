using YassineSaddikiApp.Models;
using YassineSaddikiApp.ViewModels;
//using YassineSaddikiApp.Models.ViewModels;

namespace YassineSaddikiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeDetailPage : ContentPage
    {
        public CoffeeDetailPage(CoffeeItems coffee)
        {
            InitializeComponent();
            BindingContext = new CoffeeDetailPageViewModel(coffee);
        }

        private async void Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}