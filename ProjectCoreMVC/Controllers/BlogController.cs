using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _blogService;
        public BlogController(IBlogService value)
        {
            _blogService = value;
        }


        public IActionResult Index()
        {
            var value = _blogService.GetBlogListWithCategory();
            return View(value);
        }

        public IActionResult BlogDetails(int id)
        {
            var value = _blogService.GetById(id);
            return View(value);
        }
    }
}
