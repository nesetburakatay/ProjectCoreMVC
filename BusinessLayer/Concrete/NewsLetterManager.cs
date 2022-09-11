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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newletterDal;

        public NewsLetterManager(INewsLetterDal newletterDal)
        {
            _newletterDal = newletterDal;
        }

        public void Add(NewsLetter t)
        {
            _newletterDal.Insert(t);
        }

        public void Delete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> Getlist()
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}