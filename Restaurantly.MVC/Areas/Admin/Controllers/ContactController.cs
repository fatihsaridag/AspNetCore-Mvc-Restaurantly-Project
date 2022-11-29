using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;
using System.Data;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Adminn")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

         
        public IActionResult ContactList()
        {
          var contactList =   _contactService.GetAll();
            return View(contactList);
        }


        [HttpGet]
        public IActionResult ContactEdit(int id)
        {
            var contact = _contactService.GetUpdateContact(id);
            return View(contact);
        }


        [HttpPost]
        public IActionResult ContactEdit(ContactUpdateDto contactUpdateDto)
        {
           _contactService.Update(contactUpdateDto);
            return RedirectToAction("ContactList");
        }


        public IActionResult ContactDelete(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("ContactList");
        }



    }
}
