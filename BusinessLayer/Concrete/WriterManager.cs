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
    public class WriterManager : IWriterService
    {
        IWriteDal _writerdal;

        public WriterManager(IWriteDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void Add(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> Getlist()
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}


