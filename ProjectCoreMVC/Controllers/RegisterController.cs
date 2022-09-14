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
    public class RegisterController : Controller
    {
        IWriterService _writerService;
        public RegisterController(IWriterService value)
        {
            _writerService = value;
        }
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
            _writerService.Add(value);
            return RedirectToAction("Index", "Blog");
        }
    }
}
