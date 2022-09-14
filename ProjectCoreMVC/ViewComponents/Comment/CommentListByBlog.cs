using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        ICommentService _commentService;
        public CommentListByBlog(ICommentService value)
        {
            _commentService = value;
        }


        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.GetlistById(id);
            return View(values);
        }
    }
}
