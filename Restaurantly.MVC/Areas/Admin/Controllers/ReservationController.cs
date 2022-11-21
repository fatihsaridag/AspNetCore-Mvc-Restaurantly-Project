using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public IActionResult ReservationList()
        {
            var reservations = _reservationService.GetAll();
            return View(reservations);
        }


        [HttpGet]
        public IActionResult ReservationEdit(int id)
        {
            var reservation = _reservationService.GetReservationUpdateDtoAsync(id);  //Buraya bir ReservationDto geldi ama bizim ReservationUpdateDto göndermemiz gerek.
            return View(reservation);
        }
        

        [HttpPost]
        public IActionResult ReservationEdit(ReservationUpdateDto reservationUpdateDto)
        {
            _reservationService.Update(reservationUpdateDto);
            return RedirectToAction("ReservationList");
        }


        public IActionResult ReservationDelete(int id)
        {
            _reservationService.Delete(id);
            return RedirectToAction("ReservationList");
        }

        [HttpGet]
        public IActionResult ReservationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReservationAdd(ReservationAddDto reservationAddDto)
        {
            _reservationService.Add(reservationAddDto);
            return RedirectToAction("ReservationList");
        }



    }
}
