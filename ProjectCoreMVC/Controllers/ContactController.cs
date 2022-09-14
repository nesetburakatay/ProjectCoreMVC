using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;
        public ContactController(IContactService value)
        {
            _contactService = value;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact value)
        {
            value.ContactDateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            value.ContactStatus = true;
            _contactService.Add(value);
            return RedirectToAction("Index","Contact");
        }
    }
}
