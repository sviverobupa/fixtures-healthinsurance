using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class LimitBuilder
    {
        public static ISingleObjectBuilder<LimitDto> GetDefault()
        {
            var mock = Builder<LimitDto>
                .CreateNew()
                .With(c => c.Amount = RandomNumber.Next(100, 300))
                .With(c => c.ConditionDescription = Lorem.Sentence())
                .With(c => c.LimitType = Pick<LimitTypeDto>.RandomItemFrom(new[]
                {
                    LimitTypeDto.LLPP,
                    LimitTypeDto.PM,
                    LimitTypeDto.PP,
                    LimitTypeDto.Y1PPLM,
                    LimitTypeDto.Y2PPLM,
                    LimitTypeDto.Y3PPLM,
                    LimitTypeDto.Y4PPLM
                }));
            return mock;
        }
    }
}