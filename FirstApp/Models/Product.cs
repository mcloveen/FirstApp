namespace FirstApp.Models
{

    public class Product
    {
        static int Id { get; set; } = 0;
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int ProductId { get; set; }


        public Product(string name, double price, string cat)
        {
            Price = price;
            ProductName = name;
            Category = cat;
            ProductId = Id;
            Id++;
        }


    }
}
