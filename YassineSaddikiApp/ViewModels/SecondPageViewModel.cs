using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
//using YassineSaddikiApp.Models.ViewModels;
using Newtonsoft.Json;
using YassineSaddikiApp.Models;


namespace YassineSaddikiApp.ViewModels
{
    public class SecondPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CoffeeItems> CoffeeItemsList { get; set; } = new ObservableCollection<CoffeeItems>();

        public ICommand LoadDataCommand { get; }

        public SecondPageViewModel()
        {
            LoadDataCommand = new Command(async () => await LoadCoffeeData());
        }

        private async Task LoadCoffeeData()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = "https://api.sampleapis.com/coffee/hot";
                string json = await client.GetStringAsync(url);
                var coffees = JsonConvert.DeserializeObject<List<CoffeeItems>>(json);
                foreach (var coffee in coffees)
                {
                    CoffeeItemsList.Add(coffee);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddCoffeeItem(string title, string description, string image)
        {
            var newCoffee = new CoffeeItems
            {
                Title = title,
                Description = description,
                Image = image
            };

            CoffeeItemsList.Add(newCoffee);
        }
    }
}

