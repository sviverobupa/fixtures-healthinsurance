namespace Fixtures.HealthInsurance.Products.Models
{
    public class Package
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product Hospital { get; set; }
        public Product Extras { get; set; }
        public PackageType PackageType { get; set; }

        // TODO: Map to FamilyType
        // TODO: Excess options
        // TODO: List of features
        // TODO: Link to PDF
    }
}