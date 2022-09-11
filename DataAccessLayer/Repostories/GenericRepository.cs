using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context db = new Context();

        public void Delete(T t)
        {
            db.Remove(t);
            db.SaveChanges();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return db.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            db.Add(t);
            db.SaveChanges();
        }

        public void Update(T t)
        {
            db.Update(t);
            db.SaveChanges();
        }
        public List<T> GetListAll(Expression<Func<T, bool>> Filter)
        {
            return db.Set<T>().Where(Filter).ToList();
        }

        public void test4567()
        {
            throw new NotImplementedException();
        }
    }


   
}
