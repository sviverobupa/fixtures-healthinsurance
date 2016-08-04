namespace Fixtures.HealthInsurance.Products.Models
{
    public class Limit
    {
        public decimal Amount { get; set; }
        public string ConditionDescription { get; set; }
        public LimitType LimitType { get; set; }
    }
}