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
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer value)
        {
            if (!ModelState.IsValid)
            {
                return View(value);
            }

            value.WriterAbout = "about is not empty";
            value.WriterStatus = true;
            wm.Add(value);
            return RedirectToAction("Index", "Blog");
        }
    }
}
