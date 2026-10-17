namespace CITA255___Assignment_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ProductList.ItemsSource = Products.Names;
        }

        private async void OnProductSelected(object? sender, SelectionChangedEventArgs e)
        {
     
            if (e.CurrentSelection.Count == 0)
            {
                return;
            }

            string selectedName = (string)e.CurrentSelection[0];
            int index = Products.Names.IndexOf(selectedName);

    
            ProductList.SelectedItem = null;

            await Shell.Current.GoToAsync($"product?index={index}");
        }
    }
}
