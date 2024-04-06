using Newtonsoft.Json;
using YassineSaddikiApp.Models.ViewModels;

namespace YassineSaddikiApp
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            LoadCoffeeData();
            coffeeListView.ItemTapped += CoffeeListView_ItemTapped;
        }

        private async void LoadCoffeeData()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "https://api.sampleapis.com/coffee/hot";
                string json = await client.GetStringAsync(url);
                List<CoffeeItems> coffees = JsonConvert.DeserializeObject<List<CoffeeItems>>(json);
                coffeeListView.ItemsSource = coffees;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
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
