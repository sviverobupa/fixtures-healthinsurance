namespace Fixtures.HealthInsurance.Products.Models
{
    public class ProductServiceDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int WaitingPeriodInMonths { get; set; }
        public LimitDto Limit { get; set; }
        public ProductServiceProviderTypeDto ProviderType { get; set; }
        public ProductServiceCoverTypeDto CoverType { get; set; }
        public ProductServiceTypeDto Type { get; set; }
    }
}