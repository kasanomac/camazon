namespace camazon.Models
{
    public class Product
    {
        public int ProductId {get; set;}
        public required string ProductName {get; set;}
        public required int Price {get; set;}
        public required string Description {get; set;}
        public required string ImageUrl {get; set;}
        public required string ProductCategory {get; set;}
        public required string Maker {get; set;}
    }
}