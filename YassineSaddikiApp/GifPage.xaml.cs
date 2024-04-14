using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
        BindingContext = new GifPageViewModel();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(100);
        ((GifPageViewModel)BindingContext).IsAnimationPlaying = false;
        await Task.Delay(100);
        ((GifPageViewModel)BindingContext).IsAnimationPlaying = true;
    }
}