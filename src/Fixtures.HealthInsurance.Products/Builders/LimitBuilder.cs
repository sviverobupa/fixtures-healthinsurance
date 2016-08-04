using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class LimitBuilder
    {
        public static ISingleObjectBuilder<Limit> GetDefault()
        {
            var mock = Builder<Limit>
                .CreateNew()
                .With(c => c.Amount = RandomNumber.Next(100, 300))
                .With(c => c.ConditionDescription = Lorem.Sentence())
                .With(c => c.LimitType = Pick<LimitType>.RandomItemFrom(new[]
                {
                    LimitType.LLPP,
                    LimitType.PM,
                    LimitType.PP,
                    LimitType.Y1PPLM,
                    LimitType.Y2PPLM,
                    LimitType.Y3PPLM,
                    LimitType.Y4PPLM
                }));
            return mock;
        }
    }
}