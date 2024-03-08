using Newtonsoft.Json;

namespace YassineSaddikiApp;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
        LoadCoffeeData();

    }
    private async void LoadCoffeeData()
    {
        try
        {
            HttpClient client = new HttpClient();
            string url = "https://api.sampleapis.com/coffee/hot";
            string json = await client.GetStringAsync(url);
            List<Coffee> coffees = JsonConvert.DeserializeObject<List<Coffee>>(json);
            coffeeListView.ItemsSource = coffees;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public class Coffee
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }
    }

}