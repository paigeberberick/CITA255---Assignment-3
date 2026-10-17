namespace CITA255___Assignment_3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            
            Routing.RegisterRoute("product", typeof(ProductDetailPage));
        }
    }
}
