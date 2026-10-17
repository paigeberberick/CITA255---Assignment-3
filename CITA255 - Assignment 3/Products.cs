namespace CITA255___Assignment_3
{

    public static class Products
    {
        public static List<string> Names = new List<string>
        {
            "Mana Potion",
            "Health Potion",
            "Stamina Potion",
            "Sight Enhancer Potion"
        };

        public static List<double> Prices = new List<double>
        {
            14.99,
            9.99,
            9.99,
            24.99
        };

        // health potion should be out of stock
        public static List<bool> InStock = new List<bool>
        {
            true,
            false,
            true,
            true
        };
    }
}
