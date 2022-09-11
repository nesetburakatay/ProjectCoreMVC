using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repostories;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        Context db = new Context();

        public List<Blog> GetlistWithCategory()
        {
            return db.Blogs.Include(x=>x.Category).ToList();
        }

        public void test1234()
        {
            throw new NotImplementedException();
        }
    }
}
