using YassineSaddikiApp.Models;

namespace YassineSaddikiApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{

        InitializeComponent();

        var items = new List<CollectionItems>
            {
                new CollectionItems {Title = "Caramel Compass Café", Description= "Une fusion exquise de café riche et de caramel crémeux pour une expérience irrésistible.", ImagePath = "./Resources/Images/caramel.png"},
                new CollectionItems {Title = "Capuccino Compass Café", Description= "Un tourbillon de mousse onctueuse sur un espresso robuste.", ImagePath = "./Resources/Images/cappuccino.png"},
                new CollectionItems {Title = "Café Noir", Description= "Un café noir audacieux aux notes sombres et envoûtantes.", ImagePath = "./Resources/Images/noir.png"}

            };
        carouselView.ItemsSource = items;
    }
}