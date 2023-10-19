using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _ProfileInformationVC : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationVC(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.memberFullName = values.Name + " " + values.Surname;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;

            return View();
        }
    }
}
