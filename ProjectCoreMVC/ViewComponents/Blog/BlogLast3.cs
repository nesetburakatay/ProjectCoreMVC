using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.ViewComponents.Blog
{
    public class BlogLast3 : ViewComponent
    {
        IBlogService _blogService;
        public BlogLast3(IBlogService value)
        {
            _blogService = value;
        }
        public IViewComponentResult Invoke()
        {
            var value = _blogService.GetLast3Blog();
            return View(value);

        }
    }
}
