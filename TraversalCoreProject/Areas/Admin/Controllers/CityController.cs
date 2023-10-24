using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());

            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCity(Destination destination)
        {
            //Set DestinationStatus "true" as default.
            destination.DestinationStatus = true;

            _destinationService.TAdd(destination);

            var values = JsonConvert.SerializeObject(destination);

            return Json(values);
        }

        public IActionResult GetCityById(int DestinationID)
        {
            var values = _destinationService.TGetById(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);

            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);

            _destinationService.TDelete(values);

            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);

            var jsonValues = JsonConvert.SerializeObject(destination);

            return Json(jsonValues);
        }
    }
}
