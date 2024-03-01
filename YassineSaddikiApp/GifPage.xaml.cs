namespace YassineSaddikiApp;

public partial class GifPage : ContentPage
{
	public GifPage()
	{
		InitializeComponent();
	}

    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}