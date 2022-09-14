using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectCoreMVC.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        IBlogService _blogService;
        public WriterLastBlog(IBlogService value)
        {
            _blogService = value;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _blogService.GetblogListByWriter(id);
            return View(value);

        }
    }
}
