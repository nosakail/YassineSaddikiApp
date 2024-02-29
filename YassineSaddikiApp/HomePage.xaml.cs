using YassineSaddikiApp.Models;

namespace YassineSaddikiApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{

        InitializeComponent();

        var items = new List<CollectionItems>
            {
                new CollectionItems {Title = "Caramel Compass Caf�", Description= "Une fusion exquise de caf� riche et de caramel cr�meux pour une exp�rience irr�sistible.", ImagePath = "./Resources/Images/caramel.png"},
                new CollectionItems {Title = "Capuccino Compass Caf�", Description= "Un tourbillon de mousse onctueuse sur un espresso robuste.", ImagePath = "./Resources/Images/cappuccino.png"},
                new CollectionItems {Title = "Caf� Noir", Description= "Un caf� noir audacieux aux notes sombres et envo�tantes.", ImagePath = "./Resources/Images/noir.png"}

            };
        carouselView.ItemsSource = items;
    }
}