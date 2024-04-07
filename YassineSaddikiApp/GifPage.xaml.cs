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
        await Task.Delay(100);
        stonksgif.IsAnimationPlaying = false;
        await Task.Delay(100);
        stonksgif.IsAnimationPlaying = true;
    }
}