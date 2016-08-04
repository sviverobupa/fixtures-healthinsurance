namespace Fixtures.HealthInsurance.Products.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductService[] Services { get; set; }
        public ProductType ProductType { get; set; }

        // TODO: Product detail ie What is covered, What is not covered, Useful information
    }
}