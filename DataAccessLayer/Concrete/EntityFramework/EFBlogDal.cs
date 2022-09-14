using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFBlogDal : EFRepositoryGeneric<Blog, Context>, IBlogDal
    {
        public List<Blog> GetBloglistWithCategory()
        {
            using (var content = new Context())
            {
                return content.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
