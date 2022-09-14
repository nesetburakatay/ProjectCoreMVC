using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess
{
    //"class" class olan herşey bunun içine yazılabilir.
    //"IEntity" koşulunu getirmemizin sebebi buraya sadece "IEntity" miras alınmış class lar yazılabilir. bu sayede "EntitiLayer"içindeki classlar buna yazılacak çünkü bu classlar "IEntity" den miras aldı.
    //"new()" yazılmasının sebebi newlenebilir herşe buna yazılır. bu sayede interfaces ve abstract classlar bunun içine yazılamaz.

    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter=null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
