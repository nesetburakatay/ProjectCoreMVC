using DataAccessLayer.Repostories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC.Models
{
    public class testettt
    {
        GenericRepository<Blog> db = new GenericRepository<Blog>();
        Blog a = new Blog() { BlogContent="",BlogTitle=""};
        
        public void testMethod() 
        {
            db.Insert(a);            
        }
    }
}
