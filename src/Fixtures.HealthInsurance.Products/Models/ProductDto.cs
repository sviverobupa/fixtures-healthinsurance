namespace Fixtures.HealthInsurance.Products.Models
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductServiceDto[] Services { get; set; }
        public ProductTypeDto ProductType { get; set; }

        // TODO: Product detail ie What is covered, What is not covered, Useful information
    }
}