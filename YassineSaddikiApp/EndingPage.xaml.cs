using System;
using System.Windows.Input;

using YassineSaddikiApp.ViewModels;

namespace YassineSaddikiApp
{
    public partial class EndingPage : ContentPage
    {
        public EndingPage()
        {
            //InitializeComponent();
            BindingContext = new EndingPageViewModel();
        }

 

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var vm = BindingContext as EndingPageViewModel;
            if (vm != null)
            {
                vm.WelcomeMessage = $"Merci {vm.Username}";
            }
        }
    }
}

