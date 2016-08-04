namespace Fixtures.HealthInsurance.Products.Models
{
    public class ProductService
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int WaitingPeriodInMonths { get; set; }
        public Limit Limit { get; set; }
        public ProductServiceProviderType ProviderType { get; set; }
        public ProductServiceCoverType CoverType { get; set; }
        public ProductServiceType Type { get; set; }
    }
}