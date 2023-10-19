using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideListVC : ViewComponent
    {
        GuideManager _guideManager = new GuideManager(new EfGuideDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _guideManager.TGetList();

            return View(values);
        }
    }
}
