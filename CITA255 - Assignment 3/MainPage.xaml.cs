namespace CITA255___Assignment_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // make each button go to details for item
        private async void OnManaClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ManaPotionPage());
        }

        private async void OnHealthClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new HealthPotionPage());
        }

        private async void OnStaminaClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new StaminaPotionPage());
        }

        private async void OnSightClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new SightPotionPage());
        }
    }
}