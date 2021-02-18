using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<TX> where TX:class, IEntity, new()
    {
        List<TX> GetAll(Expression<Func<TX, bool>> filter = null);
        TX Get(Expression<Func<TX, bool>> filter);
        void Add(TX entity);
        void Update(TX entity);
        void Delete(TX entity);
    }
}
