using System.Collections.Generic;
using Faker;
using Fixtures.HealthInsurance.Products.Models;
using FizzWare.NBuilder;

namespace Fixtures.HealthInsurance.Products.Builders
{
    public class ProductServicesBuilder
    {
        public static IList<ProductServiceDto> GetDefaultHospitalServices()
        {
            var generator = new UniqueRandomGenerator();
            var mock = Builder<ProductServiceDto>
                .CreateListOfSize(10)
                .All()
                .With(item => item.Description = Lorem.Paragraph(1))
                .With(item => item.WaitingPeriodInMonths = generator.Next(1, 12))
                .With(item => item.Name = Pick<string>.RandomItemFrom(new[]
                {
                    "Accommodation for overnight and same day stays",
                    "Operating theatre, intensive care, ward fees",
                    "Bupa Medical Gap Scheme Available",
                    "Surgically implanted prostheses",
                    "Accidents sustained after joining",
                    "Knee arthroscopy & meniscectomy procedures",
                    "Appendicitis",
                    "Removal of tonsils and adenoids",
                    "Dental Surgery",
                    "Minor gynaecological surgery",
                    "Psychiatric services",
                    "Rehabilitation services",
                    "Pregnancy & birth related services including childbirth",
                    "Assisted reproductive services (IVF)",
                    "Cardiac & cardiac related services",
                    "Renal dialysis for chronic renal failure",
                    "Cataract & eye lens procedures",
                    "Hip/knee replacement (including arthroplasty, revision and resurfacing procedures)",
                    "All other joint replacements",
                    "Gastric banding and all obesity related treatments",
                    "All other in-patient treatments receiving a Medicare benefit",
                    "Emergency Ambulance Services~",
                    "Family and hospital benefits",
                    "Health Subscription Refunds (contact us for details)",
                    "Unemployment cover"
                }))
                .With(
                    item =>
                        item.CoverType =
                            Pick<ProductServiceCoverTypeDto>.RandomItemFrom(new[]
                            {
                                ProductServiceCoverTypeDto.CoveredWithCondition,
                                ProductServiceCoverTypeDto.FullyCovered,
                                ProductServiceCoverTypeDto.MinimumBenefit,
                                ProductServiceCoverTypeDto.NotCovered,
                            }))
                .With(
                    item =>
                        item.ProviderType =
                            Pick<ProductServiceProviderTypeDto>.RandomItemFrom(new[]
                            {
                                ProductServiceProviderTypeDto.AllProviders,
                                ProductServiceProviderTypeDto.MemberFirst,
                                ProductServiceProviderTypeDto.NonMembersFirst
                            }))
                .With(
                    item =>
                        item.Type = ProductServiceTypeDto.Hospital)
                .With(item => item.Limit = LimitBuilder.GetHospitalDefault());

            return mock.Build();
        }

        public static IList<ProductServiceDto> GetDefaultExtrasServices()
        {
            var generator = new UniqueRandomGenerator();
            var mock = Builder<ProductServiceDto>
                .CreateListOfSize(10)
                .All()
                .With(item => item.Description = Lorem.Paragraph(1))
                .With(item => item.WaitingPeriodInMonths = generator.Next(1, 12))
                .With(item => item.Name = Pick<string>.RandomItemFrom(new[]
                {
                    "General Dental",
                    "Major dental",
                    "Orthodontics",
                    "Optical",
                    "Physiotherapy",
                    "Chiropractic and osteopathy",
                    "Antenatal and postnatal",
                    "Natural Therapies",
                    "Living Well Programs",
                    "Pharmacy",
                    "Dietary",
                    "Psychology",
                    "Podiatry",
                    "Speech Therapy",
                    "Eye Therapy",
                    "Occupational Therapy",
                    "Home Nursing",
                    "Health aids and appliances",
                    "Travel and accommodation expenses",
                    "Emergency Ambulance Services",
                    "Top Up Bonus",
                    "Travel Well Benefits"
                }))
                .With(
                    item =>
                        item.CoverType =
                            Pick<ProductServiceCoverTypeDto>.RandomItemFrom(new[]
                            {
                                ProductServiceCoverTypeDto.CoveredWithCondition,
                                ProductServiceCoverTypeDto.FullyCovered,
                                ProductServiceCoverTypeDto.MinimumBenefit,
                                ProductServiceCoverTypeDto.NotCovered,
                            }))
                .With(
                    item =>
                        item.ProviderType =
                            Pick<ProductServiceProviderTypeDto>.RandomItemFrom(new[]
                            {
                                ProductServiceProviderTypeDto.AllProviders,
                                ProductServiceProviderTypeDto.MemberFirst,
                                ProductServiceProviderTypeDto.NonMembersFirst
                            }))
                .With(
                    item =>
                        item.Type = ProductServiceTypeDto.Extras)
                .With(item => item.Limit = LimitBuilder.GetExtrasDefault());

            return mock.Build();
        }
    }
}