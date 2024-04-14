using Newtonsoft.Json;
using YassineSaddikiApp.Models.ViewModels;
using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp
{
    public partial class SecondPage : ContentPage
    {
        SecondPageViewModel viewModel;

        public SecondPage()
        {
            InitializeComponent();
            viewModel = new SecondPageViewModel();
            BindingContext = viewModel;
            LoadCoffeeData();
            coffeeListView.ItemTapped += CoffeeListView_ItemTapped;
        }

        private async void LoadCoffeeData()
        {
            viewModel.LoadDataCommand.Execute(null);
        }

        private async void CoffeeListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is CoffeeItems coffee)
            {
                await Navigation.PushAsync(new CoffeeDetailPage(coffee));
            }
        }
    }
}
