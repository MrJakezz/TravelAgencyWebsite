using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.UserEditName = values.Name;
            userEditViewModel.UserEditSurname = values.Surname;
            userEditViewModel.UserEditPhoneNumber = values.PhoneNumber;
            userEditViewModel.UserEditMail = values.Email;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userEditViewModel.UserEditImage != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.UserEditImage.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);

                await userEditViewModel.UserEditImage.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }

            user.Name = userEditViewModel.UserEditName;
            user.Surname = userEditViewModel.UserEditSurname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.UserEditPassword);

            var result = await _userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
