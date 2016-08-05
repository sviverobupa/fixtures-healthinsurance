using System.Diagnostics;
using Fixtures.HealthInsurance.Products.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fixtures.HealthInsurance.Products.Tests
{
    [TestClass]
    public class ProductDetailBuilderTests
    {
        [TestMethod]
        public void GetDefault_NotNull()
        {
            var package = ProductDetailBuilder.GetDefault();
            Assert.IsNotNull(package);

            // echo some values
            foreach (var item in package)
            {
                Trace.WriteLine($"item.Id: {item.Id}");
                Trace.WriteLine($"item.Price: {item.Price}");
                Trace.WriteLine($"item.Hospital.Name: {item.Hospital.Name}");

                foreach (var hospitalService in item.Hospital.Services)
                {
                    Trace.WriteLine($"hospitalService.Name: {hospitalService.Name}");
                    Trace.WriteLine($"hospitalService.CoverType: {hospitalService.CoverType}");
                }

                foreach (var extrasService in item.Extras.Services)
                {
                    Trace.WriteLine($"extrasService.Name: {extrasService.Name}");
                    Trace.WriteLine($"extrasService.CoverType: {extrasService.CoverType}");
                }
            }
        }
    }
}