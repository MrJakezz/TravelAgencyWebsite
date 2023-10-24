using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")] //Route Configuration
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            //Validator
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);

            if (result.IsValid)
            {
                _guideService.TAdd(guide);

                return RedirectToAction("Index");
            }

            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetById(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.TGetById(id);
            _guideService.TDelete(values);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangeToActive(int id) 
        {
            _guideService.TChangeToActive(id);

            return RedirectToAction("Index", "Guide", new {area="Admin"});
        }

        public IActionResult ChangeToPassive(int id)
        {
            _guideService.TChangeToPassive(id);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
