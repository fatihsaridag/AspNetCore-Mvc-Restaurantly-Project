using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Data.EntityFramework.Contexts;
using Restaurantly.Services.Abstract;
using System.Data;
using System.Linq;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Adminn")]
    public class DashboardController : Controller
    {
        private readonly IReservationService _reservationService;

        public DashboardController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            RestaurantlyContext context = new RestaurantlyContext();
            var reservationCount = context.Reservations.Count();
            var userCount = context.Users.Count();
            var menuCount = context.Menus.Count();

            ViewData["ReservationCount"] = reservationCount;
            ViewData["UserCount"] = userCount;
            ViewData["MenuCount"] = menuCount;


            var reservationListDto = _reservationService.GetAll();


            return View(reservationListDto);
        }
    }
}
