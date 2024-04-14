using System.ComponentModel;
using System.Windows.Input;


namespace YassineSaddikiApp.ViewModels
{
    public class GifPageViewModel : INotifyPropertyChanged
    {
        private bool _isAnimationPlaying;
        public bool IsAnimationPlaying
        {
            get => _isAnimationPlaying;
            set
            {
                if (_isAnimationPlaying != value)
                {
                    _isAnimationPlaying = value;
                    OnPropertyChanged(nameof(IsAnimationPlaying));
                }
            }
        }

        public ICommand BackCommand { get; }

        public GifPageViewModel()
        {
            BackCommand = new Command(async () => await Back());
        }

        private async Task Back()
        {
            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

