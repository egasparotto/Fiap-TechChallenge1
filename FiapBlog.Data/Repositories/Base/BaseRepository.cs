using FiapBlog.Data.Context;
using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Repositories.Base;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapBlog.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : Entity
    {
        protected ApplicationDbContext Context { get; set; }

        protected BaseRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

        public virtual TEntity Get(Func<TEntity, bool> func)
        {
            return GetAll().FirstOrDefault(func);
        }

        public virtual void Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            Context.SaveChanges();
        }

        public virtual void Delete(Func<TEntity, bool> func)
        {
            Context.Set<TEntity>().Remove(Get(func));
            Context.SaveChanges();
        }






    }
}
