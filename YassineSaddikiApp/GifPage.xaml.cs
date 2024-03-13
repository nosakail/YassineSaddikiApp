namespace YassineSaddikiApp;

public partial class GifPage : ContentPage
{
	public GifPage()
	{
		InitializeComponent();
        OnAppearing();

    }

    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(1000);
        stonksgif.IsAnimationPlaying = true;
    }
}