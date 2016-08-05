namespace Fixtures.HealthInsurance.Products.Models
{
    public class LimitDto
    {
        public decimal Amount { get; set; }
        public string ConditionDescription { get; set; }
        public LimitTypeDto LimitType { get; set; }
    }
}