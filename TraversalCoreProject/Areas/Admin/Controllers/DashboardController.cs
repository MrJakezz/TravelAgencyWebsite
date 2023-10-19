using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            ViewBag.tourCount = context.Destinations.Count();
            ViewBag.clientCount = context.Users.Count();

            return View();
        }
    }
}
