using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog t)
        {
            _blogDal.Add(t);
        }
        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }
        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }
        public List<Blog> Getlist()
        {
            throw new NotImplementedException();
        }
        public Blog GetById(int id)
        {
            return _blogDal.Get(x => x.BlogId == id);
        }




        public List<Blog> GetblogListByWriter(int id)
        {
            return _blogDal.GetList(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetBloglistWithCategory();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetList().OrderByDescending(x => x.BlogCreateDateTime).Take(3).ToList();
        }


        //public void Add(Blog t)
        //{
        //    throw new NotImplementedException();
        //}
        //public void Delete(Blog t)
        //{
        //    throw new NotImplementedException();
        //}
        //public void Update(Blog t)
        //{
        //    throw new NotImplementedException();
        //}
        //public List<Blog> Getlist()
        //{

        //    return _blogDal.GetList();
        //}
        //public Blog GetById(int id)
        //{
        //    return _blogDal.GetByID(id);
        //}


        //public List<Blog> GetBlogListWithCategory()
        //{
        //    return _blogDal.GetlistWithCategory();
        //}
        //public List<Blog> GetBlogById(int id)
        //{
        //    return _blogDal.GetListAll(x => x.BlogId == id);
        //}
        //public List<Blog> GetblogListByWriter(int id)
        //{
        //    return _blogDal.GetListAll(x => x.WriterId == id);
        //}
        //public List<Blog> GetLast3Blog() 
        //{
        //    return _blogDal.GetListAll().OrderByDescending(x => x.BlogCreateDateTime).Take(3).ToList();
        //}
    }
}
