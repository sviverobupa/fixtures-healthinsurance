using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;
using System.Linq;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class ProductBuilder
    {
        public static ProductDto GetDefaultHospital()
        {
            var mock = Builder<ProductDto>
                .CreateNew()
                .With(item => item.Name = Pick<string>.RandomItemFrom(new[]
                {
                    "Top Hospital Cover",
                    "Family Essentials Hospital Cover",
                    "Ultimate Health Hospital Cover",
                    "Young Singles Choice Hospital",
                    "Young Singles Saver Hospital",
                    "Active Saver Hospital",
                    "Top Hospital Cover with $250 Excess",
                    "Top Hospital Cover with $500 Excess",
                    "Budget Hospital with $250 Excess",
                    "Budget Hospital with $500 Excess",
                    "Choices Hospital",
                    "Standard Hospital with $250 Excess",
                    "Standard Hospital with $500 Excess",
                    "Growing Family Hospital Cover with $250 Excess",
                    "Growing Family Hospital Cover with $500 Excess",
                    "Budget Family Hospital Cover with $250 Excess",
                    "Budget Family Hospital Cover with $500 Excess",
                    "Established Family Hospital Cover with $250 Excess",
                    "Established Family Hospital Cover with $500 Excess",
                    "Live Well Nil Excess Hospital",
                    "Live Well $250 Hospital",
                    "Live Well $500 Hospital"
                }))
                .With(item => item.Description = Lorem.Paragraph(3))
                .With(c => c.Services = ProductServicesBuilder.GetDefaultHospitalServices().ToArray())
                .With(item => item.ProductType = ProductTypeDto.Hospital);
            return mock.Build();
        }

        public static ProductDto GetDefaultExtras()
        {
            var mock = Builder<ProductDto>
                .CreateNew()
                .With(item => item.Name = Pick<string>.RandomItemFrom(new[]
                {
                    "Your Choice Extras",
                    "Ultimate Health Extras Cover",
                    "Young Singles Saver Ancillary",
                    "Young Singles Choice Ancillary",
                    "Active Saver Extras",
                    "Ultimate Health Extras Cover",
                    "Silver Extras",
                    "Silver Extras",
                    "Gold Extras",
                    "Gold Extras",
                    "Platinum Extras",
                    "Platinum Extras",
                    "Choices with 70% back Extras",
                    "Choices with 80% back Extras",
                    "Choices with 90% back Extras",
                    "Bronze Extras",
                    "Growing Family Ancillary Cover",
                    "Growing Family Ancillary Cover",
                    "Budget Family Ancillary Cover",
                    "Established Family Ancillary Cover",
                    "Live Well Ancillary Cover"
                }))
                .With(item => item.Description = Lorem.Paragraph(3))
                .With(c => c.Services = ProductServicesBuilder.GetDefaultExtrasServices().ToArray())
                .With(item => item.ProductType = ProductTypeDto.Extras);
            return mock.Build();
        }
    }
}