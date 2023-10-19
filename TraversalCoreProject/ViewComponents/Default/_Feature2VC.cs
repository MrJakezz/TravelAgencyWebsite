using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature2VC : ViewComponent
    {
        private readonly IFeature2Service _feature2Service;

        public _Feature2VC(IFeature2Service feature2Service)
        {
            _feature2Service = feature2Service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _feature2Service.TGetList();

            return View(values);
        }
    }
}
