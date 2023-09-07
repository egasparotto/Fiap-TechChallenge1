using FiapBlog.Data.Context;
using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Repositories.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
        protected ApplicationDbContext Context { get; }
        protected ILogger<BaseRepository<TEntity>> Logger { get; }

        protected BaseRepository(ApplicationDbContext context, ILogger<BaseRepository<TEntity>> logger)
        {
            Context = context;
            Logger = logger;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            Logger.LogInformation("Consultando {0} no banco de dados", typeof(TEntity).Name);
            return Context.Set<TEntity>();
        }

        public virtual TEntity Get(Func<TEntity, bool> func)
        {
            return GetAll().FirstOrDefault(func);
        }

        public virtual void Insert(TEntity entity)
        {
            Logger.LogInformation("Inserindo {0} no banco de dados", typeof(TEntity).Name);
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            Logger.LogInformation("Atualizando {0} no banco de dados", typeof(TEntity).Name);
            Context.Set<TEntity>().Update(entity);
            Context.SaveChanges();
        }

        public virtual void Delete(Func<TEntity, bool> func)
        {
            Logger.LogInformation("Deletando {0} no banco de dados", typeof(TEntity).Name);
            Context.Set<TEntity>().Remove(Get(func));
            Context.SaveChanges();
        }

    }
}
