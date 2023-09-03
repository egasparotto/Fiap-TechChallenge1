using FiapBlog.Domain.Entities.Base;
using FiapBlog.Domain.Interfaces.Entities.Base;

namespace FiapBlog.Domain.Interfaces.Services.Base
{
    public interface IBaseService<TEntity>
        where TEntity : Entity, IAggregateRoot
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
