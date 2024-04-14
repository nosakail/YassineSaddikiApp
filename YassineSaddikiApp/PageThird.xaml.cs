using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp
{
    public partial class PageThird : ContentPage
    {
        SecondPageViewModel secondPageViewModel;
        private UploadImage uploadImage;

        public PageThird()
        {
            InitializeComponent();
            secondPageViewModel = new SecondPageViewModel();
            BindingContext = secondPageViewModel;
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
                secondPageViewModel.AddCoffeeItem(titre, description, (Image_Upload.Source as FileImageSource)?.File);
                Shell.Current.Navigation.PopAsync();
            }
        }
    }
}
