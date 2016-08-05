namespace Fixtures.HealthInsurance.Products.Models
{
    public class ProductDetailDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductDto Hospital { get; set; }
        public ProductDto Extras { get; set; }
        public PackageTypeDto PackageType { get; set; }

        // TODO: Map to FamilyType
        // TODO: Excess options
        // TODO: List of features
        // TODO: Link to PDF
    }
}