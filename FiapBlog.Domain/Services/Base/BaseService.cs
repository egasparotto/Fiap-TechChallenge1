using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Entities.Base;
using FiapBlog.Domain.Interfaces.Repositories.Base;
using FiapBlog.Domain.Interfaces.Services.Base;

namespace FiapBlog.Domain.Services.Base
{
    public abstract class BaseService<TEntity, TRepository> : IBaseService<TEntity>
        where TEntity : Entity, IAggregateRoot
        where TRepository : IBaseRepository<TEntity>
    {
        protected TRepository Repository { get; }
        protected BaseService(TRepository repository)
        {
            Repository = repository;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public virtual TEntity GetById(int id)
        {
            return Repository.Get(x => x.Id == id);
        }
        public virtual void Insert(TEntity entity)
        {
            Repository.Insert(entity);
        }

        public virtual void Update(TEntity entity)
        {
            Repository.Update(entity);
        }

        public virtual void Delete(int id)
        {
            Repository.Delete(x => x.Id == id);
        }
    }
}
