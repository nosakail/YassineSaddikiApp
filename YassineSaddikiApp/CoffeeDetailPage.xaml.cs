namespace YassineSaddikiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeDetailPage : ContentPage
    {
        public CoffeeDetailPage(Coffee coffee)
        {
            InitializeComponent();
            BindingContext = coffee;
            LoadCoffeeDetails(coffee);
        }

        private void LoadCoffeeDetails(Coffee coffee)
        {
            titleLabel.Text = coffee.Title;
            descriptionLabel.Text = coffee.Description;
            coffeeImage.Source = coffee.Image;
        }
    }
}