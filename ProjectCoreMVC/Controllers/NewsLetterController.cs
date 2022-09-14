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
    public class NewsLetterController : Controller
    {
        INewsLetterService _newsletterService;
        public NewsLetterController(INewsLetterService value)
        {
            _newsletterService = value;
        }
        public IActionResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter value)
        {
            value.MailStatus = true;
            _newsletterService.Add(value);
            return RedirectToAction("Index","Home");
        }
    }
}
