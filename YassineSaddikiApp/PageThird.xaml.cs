using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp
{
    public partial class PageThird : ContentPage
    {
        public PageThird()
        {
            InitializeComponent();
            BindingContext = new ThirdPageViewModel(new SecondPageViewModel());
        }
    }
}
