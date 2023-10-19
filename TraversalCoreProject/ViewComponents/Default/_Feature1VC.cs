using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature1VC : ViewComponent
    {
        private readonly IFeature1Service _feature1Service;

        public _Feature1VC(IFeature1Service feature1Service)
        {
            _feature1Service = feature1Service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _feature1Service.TGetList();

            return View(values);
        }
    }
}
