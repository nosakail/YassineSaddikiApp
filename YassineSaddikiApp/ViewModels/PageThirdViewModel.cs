using System;
using System.ComponentModel;
using System.Windows.Input;
using YassineSaddikiApp.Models;
using Plugin.Media;

namespace YassineSaddikiApp.ViewModels
{
    public class ThirdPageViewModel : INotifyPropertyChanged
    {
        private string _titre;
        public string Titre
        {
            get { return _titre; }
            set
            {
                if (_titre != value)
                {
                    _titre = value;
                    OnPropertyChanged(nameof(Titre));
                }
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged(nameof(ImageSource));
                }
            }
        }

        public ICommand UploadImageCommand { get; }
        public ICommand AddToListCommand { get; }

        private readonly SecondPageViewModel _secondPageViewModel;

        public ThirdPageViewModel(SecondPageViewModel secondPageViewModel)
        {
            _secondPageViewModel = secondPageViewModel;
            UploadImageCommand = new Command(UploadImage);
            AddToListCommand = new Command(AddToList);
        }

        private async void UploadImage()
        {
            var uploadImage = new UploadImage();
            var img = await uploadImage.OpenMediaPickerAsync();
            var imagefile = await uploadImage.Upload(img);
            ImageSource = ImageSource.FromStream(() => uploadImage.ByteArrayToStream(uploadImage.StringToByteBase64(imagefile.byteBase64)));
        }

        private void AddToList()
        {
            if (string.IsNullOrWhiteSpace(Titre) || string.IsNullOrWhiteSpace(Description) || ImageSource == null)
            {
                Application.Current.MainPage.DisplayAlert("Erreur", "Veuillez remplir tous les champs", "OK");
            }
            else
            {
                if (ImageSource is FileImageSource fileImageSource)
                {
                    _secondPageViewModel.AddCoffeeItem(Titre, Description, fileImageSource.File);
                }
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


