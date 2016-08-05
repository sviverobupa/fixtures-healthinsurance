namespace Fixtures.HealthInsurance.Products.Models
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProductServiceDto[] Services { get; set; }
        public ProductTypeDto ProductType { get; set; }
        public string CoverDescription { get; set; }
        public string NotCoveredDescription { get; set; }
        public string OtherInformation { get; set; }
    }
}