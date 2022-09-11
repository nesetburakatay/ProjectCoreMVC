using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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

        BlogManager bm = new BlogManager(new EFBlogRepository());


        public IActionResult Index()
        {
            var value1 = bm.Getlist();
            var value2 = bm.GetBlogListWithCategory();
            return View(value2);
        }

        public IActionResult BlogDetails(int id)
        {
            var value = bm.GetBlogById(id);
            return View(value);
        }
    }
}
