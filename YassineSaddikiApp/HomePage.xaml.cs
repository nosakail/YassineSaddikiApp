using YassineSaddikiApp.Models;
using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }

    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GifPage());
    }
}