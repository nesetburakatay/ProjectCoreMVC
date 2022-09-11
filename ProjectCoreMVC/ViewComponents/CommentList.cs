using Microsoft.AspNetCore.Mvc;
using ProjectCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment{Id=1,Username="user1"},
                new UserComment{Id=2,Username="user2"},
                new UserComment{Id=3,Username="user3"},
                new UserComment{Id=4,Username="user4"},
                new UserComment{Id=5,Username="user5"}
            };
            return View(commentvalues); 
        }
    }
}
