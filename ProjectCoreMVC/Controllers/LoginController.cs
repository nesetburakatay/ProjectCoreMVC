using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjectCoreMVC.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer value)
        {
            //Context c = new Context();
            //var datavalue = c.Writers.Select(x => x.WriterMail == value.WriterMail && x.WriterPassword == value.WriterPassword).FirstOrDefault();
            //if (datavalue != true)
            //{
            //    var claims = new List<Claim>() 
            //    {
            //        new Claim(ClaimTypes.Name,value.WriterMail)
            //    };
            //    var useridentity = new ClaimsIdentity(claims,"a");
            //    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            //    await HttpContext.SignInAsync(principal);


            //    HttpContext.Session.SetString("username", value.WriterName);
            //    return RedirectToAction("Index", "Writer");
            //}
            //else
            //{
            //    return View();

            //}
             return View();

        }
    }
}
