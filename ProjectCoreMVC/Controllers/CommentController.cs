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
    public class CommentController : Controller
    {
        ICommentService _commentService;
        public CommentController(ICommentService value)
        {
            _commentService = value;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddComment(Comment value,int id)
        {
            value.CommentDateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            value.CommentStatus = true;
            value.BlogId = id;
            _commentService.Add(value);
            return RedirectToAction("BlogDetails", "Blog",new { Controller="Blog",Action="BlogDetails",id=id});
        }
        public PartialViewResult CommentListByBlog(int id)
        {   
            var value = _commentService.GetlistById(id);
            return PartialView(value);
        }
    }
}
