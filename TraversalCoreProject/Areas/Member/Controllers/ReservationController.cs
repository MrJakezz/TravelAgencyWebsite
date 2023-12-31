﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

        ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var listValues = _reservationManager.GetListWithReservationByAccepted(values.Id);

            return View(listValues);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var listValues = _reservationManager.GetListWithReservationByExpired(values.Id);

            return View(listValues);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var listValues = _reservationManager.GetListWithReservationByApproval(values.Id);

            return View(listValues);
        }

        [HttpGet]
        public IActionResult NewReservation()   
        {
            List<SelectListItem> values = (from x in _destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.DestinationCity,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();

            ViewBag.v = values;

            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserID = 1; //
            reservation.ReservationStatus = "Pending";

            _reservationManager.TAdd(reservation);

            return RedirectToAction("MyCurrentReservation");
        }
    }
}
