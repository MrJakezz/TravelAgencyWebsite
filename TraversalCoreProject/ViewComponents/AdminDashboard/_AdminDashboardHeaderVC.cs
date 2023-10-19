using Microsoft.AspNetCore.Mvc;
namespace TraversalCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeaderVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
