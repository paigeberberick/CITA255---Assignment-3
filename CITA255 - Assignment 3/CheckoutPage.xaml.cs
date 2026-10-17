namespace CITA255___Assignment_3
{
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }

       
        protected override void OnAppearing()
        {
            base.OnAppearing();
            RefreshCart();
        }

        private void RefreshCart()
        {
            List<string> lines = new List<string>();
            double total = 0;

            for (int i = 0; i < Cart.Names.Count; i++)
            {
                lines.Add(Cart.Quantities[i] + " × " + Cart.Names[i]);
                total = total + Cart.Prices[i] * Cart.Quantities[i];
            }

            CartList.ItemsSource = lines;
            TotalLabel.Text = "Total:  $" + total.ToString("F2");

         
            EmptyLabel.IsVisible = (Cart.Names.Count == 0);
        }

        private async void OnCheckoutClicked(object? sender, EventArgs e)
        {
         
            if (Cart.Names.Count == 0)
            {
                await DisplayAlertAsync("Nothing yet!", "You haven't gotten anything yet! Make sure to pick out a good potion!", "Got it!");
                return;
            }

            Cart.Names.Clear();
            Cart.Prices.Clear();
            Cart.Quantities.Clear();

            RefreshCart();

            await DisplayAlertAsync("Order Placed", "Come to Sylvias again for all your potion needs!", "Got it!");
        }
    }
}