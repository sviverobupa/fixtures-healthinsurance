using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class ProductDetailBuilder
    {
        public static IListBuilder<ProductDetailDto> GetDefault()
        {
            var mock = Builder<ProductDetailDto>.CreateListOfSize(37)
                .All()
                .With(c => c.Price = RandomNumber.Next(50, 100))
                .With(c => c.Hospital = ProductBuilder.GetDefaultHospital().Build())
                .With(c => c.Extras = ProductBuilder.GetDefaultExtras().Build());
            return mock;
        }
    }
}
