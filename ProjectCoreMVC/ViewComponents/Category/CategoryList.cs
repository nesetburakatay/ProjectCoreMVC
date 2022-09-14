using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        ICategoryService _categoryService;
        public CategoryList(ICategoryService value)
        {
            _categoryService = value;
        }

        public IViewComponentResult Invoke()
        {
            var value = _categoryService.Getlist();
            return View(value);
        }
    }
}
