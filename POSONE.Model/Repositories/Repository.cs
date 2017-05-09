using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using POSONE.Model.Models;


namespace POSONE.Model.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        void IRepository<TEntity>.Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        void IRepository<TEntity>.AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        IEnumerable<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        TEntity IRepository<TEntity>.Get(int id)
        {
           return Context.Set<TEntity>().Find(id);
        }

        TEntity IRepository<TEntity>.Get(string id)
        {
           return Context.Set<TEntity>().Find(id);
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        void IRepository<TEntity>.RemoveRange(IEnumerable<TEntity> entities)
        {
              Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}