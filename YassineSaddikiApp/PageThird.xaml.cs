using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp;

public partial class PageThird : ContentPage
{
	UploadImage uploadImage { get; set; }
	public PageThird()
	{
		InitializeComponent();
        uploadImage = new UploadImage();

    }

	private async void UploadImage_Clicked(object sender, EventArgs e)
	{
		var img = await uploadImage.OpenMediaPickerAsync();

		var imagefile = await uploadImage.Upload(img);

		Image_Upload.Source = ImageSource.FromStream(() => uploadImage.ByteArrayToStream(uploadImage.StringToByteBase64(imagefile.byteBase64)));

    }

    private void AddToListButton_Clicked(object sender, EventArgs e)
    {
        string titre = titreEntry.Text;
        string description = descriptionEditor.Text;

        
        if (string.IsNullOrWhiteSpace(titre) || string.IsNullOrWhiteSpace(description) || Image_Upload.Source == null)
        {
            DisplayAlert("Erreur", "Veuillez remplir tous les champs", "OK");
        }
        else
        {
            
            var secondPage = Shell.Current.Navigation.NavigationStack.OfType<SecondPage>().FirstOrDefault();
            if (secondPage != null)
            {
                secondPage.AddCoffeeItem(titre, description, (Image_Upload.Source as FileImageSource)?.File);
            }
            
            Shell.Current.Navigation.PopAsync();
        }
    }

}