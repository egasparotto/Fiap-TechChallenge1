using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Entities.Base;

namespace FiapBlog.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntity>
        where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Func<TEntity, bool> func);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Func<TEntity, bool> func);
    }
}
