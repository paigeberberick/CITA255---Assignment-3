namespace CITA255___Assignment_3
{

    [QueryProperty(nameof(ProductIndex), "index")]
    public partial class ProductDetailPage : ContentPage
    {
        int productIndex = 0;

        public ProductDetailPage()
        {
            InitializeComponent();
        }

       
        public string ProductIndex
        {
            set
            {
                productIndex = int.Parse(value);

                Title = Products.Names[productIndex];
                NameLabel.Text = Products.Names[productIndex];
                PriceLabel.Text = "$" + Products.Prices[productIndex].ToString("F2");

                if (Products.InStock[productIndex])
                {
                    StockLabel.Text = "In stock";
                    StockLabel.TextColor = Colors.Green;
                    AddBtn.IsEnabled = true;
                }
                else
                {
                    StockLabel.Text = "Out of stock";
                    StockLabel.TextColor = Colors.Red;
                    AddBtn.IsEnabled = false;
                }
            }
        }

        private async void OnAddToCartClicked(object? sender, EventArgs e)
        {
           
            int quantity;
            bool isNumber = int.TryParse(QuantityEntry.Text, out quantity);

            if (isNumber == false || quantity <= 0)
            {
                await DisplayAlertAsync("Invalid Quantity", "That doesn't really work... please enter a whole number!", "Got it!");
                return;
            }

           
            if (Products.InStock[productIndex] == false)
            {
                await DisplayAlertAsync("Out of Stock", "Sorry, we're all out of that!", "Got it!");
                return;
            }

          
            Cart.Names.Add(Products.Names[productIndex]);
            Cart.Prices.Add(Products.Prices[productIndex]);
            Cart.Quantities.Add(quantity);

          
            await DisplayAlertAsync("Added to haul", "Added " + quantity + " × " + Products.Names[productIndex] + ".", "Got it!");
        }
    }
}
