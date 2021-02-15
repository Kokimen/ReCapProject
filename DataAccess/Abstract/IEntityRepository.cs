using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<TX> where TX:class,new()
    {
        List<TX> GetAll(Expression<Func<TX, bool>> filter = null);
        TX Get(Expression<Func<TX, bool>> filter);
        void Add(TX entity);
        void Update(TX entity);
        void Delete(TX entity);
    }
}
