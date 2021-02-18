using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TXEntity, TXContext>:IEntityRepository<TXEntity>
        where TXEntity:class,IEntity,new()
        where TXContext: DbContext, new()
    {
        public void Add(TXEntity entity)
        {
            using (TXContext context = new TXContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TXEntity entity)

        {
            using (TXContext context = new TXContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public TXEntity Get(Expression<Func<TXEntity, bool>> filter)

        {
            using (TXContext context = new TXContext())
            {
                return context.Set<TXEntity>().SingleOrDefault(filter);
            }

        }

        public List<TXEntity> GetAll(Expression<Func<TXEntity, bool>> filter = null)
        {
            using (TXContext context = new TXContext())
            {
                return filter == null
                    ? context.Set<TXEntity>().ToList()
                    : context.Set<TXEntity>().Where(filter).ToList();
            }
        }

        public void Update(TXEntity entity)
        {
            using (TXContext context = new TXContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
