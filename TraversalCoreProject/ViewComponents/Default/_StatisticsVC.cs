using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsVC : ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IGuideService _guideService;
        private readonly ITestimonialService _testimonialService;

        public _StatisticsVC(IDestinationService destinationService, IGuideService guideService, ITestimonialService testimonialService)
        {
            _destinationService = destinationService;
            _guideService = guideService;
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var statistics = new StatisticsViewModel()
            {
                Destinations = Convert.ToString(_destinationService.GetDestinationCount()),
                Guides = Convert.ToString(_guideService.GetGuideCount()),
                Customers = Convert.ToString(_testimonialService.GetCustomerCount()),
            };

            return View(statistics);
        }
    }
}
