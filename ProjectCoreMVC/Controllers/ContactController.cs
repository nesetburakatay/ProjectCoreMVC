using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        ContactManager cm = new ContactManager(new EFContactRepository());
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
            cm.Add(value);
            return RedirectToAction("Index","Contact");
        }
    }
}
