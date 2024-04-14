using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YassineSaddikiApp.Models;

using System.Collections.Generic;
using System.ComponentModel;


namespace YassineSaddikiApp.ViewModels
{
    public class HomePageViewModel
    {
        public List<CollectionItems> Items { get; }

        public ICommand GifCommand { get; }

        public HomePageViewModel()
        {
            Items = new List<CollectionItems>
        {
            new CollectionItems {Title = "Caramel Compass Café", Description= "Une fusion exquise de café riche et de caramel crémeux pour une expérience irrésistible.", ImagePath = "./Resources/Images/caramel.png"},
            new CollectionItems {Title = "Capuccino Compass Café", Description= "Un tourbillon de mousse onctueuse sur un espresso robuste.", ImagePath = "./Resources/Images/cappuccino.png"},
            new CollectionItems {Title = "Café Noir", Description= "Un café noir audacieux aux notes sombres et envoûtantes.", ImagePath = "./Resources/Images/noir.png"}
        };

            GifCommand = new Command(async () => await Gif());
        }

        private async Task Gif()
        {
            await Shell.Current.GoToAsync("//GifPage");
        }
    }

}

