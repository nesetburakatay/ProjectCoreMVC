using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService value)
        {
            _categoryService = value;
        }
        public IActionResult Index()
        {
            var values = _categoryService.Getlist();
            //var values = cm.Getlist();
            return View(values);
        }
    }
}
