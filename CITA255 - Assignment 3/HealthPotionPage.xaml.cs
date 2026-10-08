namespace CITA255___Assignment_3
{
    public partial class HealthPotionPage : ContentPage
    {
        public HealthPotionPage()
        {
            InitializeComponent();
        }

        // show message for adding potion to cart

        private void OnAddToCartClicked(object? sender, EventArgs e)
        {
            int quantity;
            bool isNumber = int.TryParse(QuantityEntry.Text, out quantity);

            
            if (isNumber == false || quantity <= 0)
            {
                DisplayAlertAsync("Invalid Amount", "That doesn't really work... enter a whole number please!", "Got it!");
                return;
            }

            DisplayAlertAsync("Added to Cart", "Added " + quantity + " x Health Potion to your haul!", "Got it!");
        }
    }
}