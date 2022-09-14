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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }


        public void Add(Comment t)
        {
            _commentDal.Add(t);
        }
        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }
        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Comment> Getlist()
        {
            throw new NotImplementedException();
        }
        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetlistById(int id)
        {
            return _commentDal.GetList(x => x.BlogId == id);
        }
    }
}
