using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var senderValues = _accountService.TGetByID(model.SenderID);
            var recieverValues = _accountService.TGetByID(model.RecieverID);

            senderValues.AccountBalance -= model.Amount;
            recieverValues.AccountBalance += model.Amount;

            List<Account> modifiedAccount = new List<Account>()
            {
                senderValues,
                recieverValues
            };

            _accountService.TMultiUpdate(modifiedAccount);

            return View();
        }
    }
}
