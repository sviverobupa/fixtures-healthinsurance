using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class PackageBuilder
    {
        public static IListBuilder<Package> GetDefault()
        {
            var mock = Builder<Package>.CreateListOfSize(37)
                .All()
                .With(c => c.Price = RandomNumber.Next(50, 100))
                .With(c => c.Hospital = ProductBuilder.GetDefaultHospital().Build())
                .With(c => c.Extras = ProductBuilder.GetDefaultExtras().Build());
            return mock;
        }
    }
}
