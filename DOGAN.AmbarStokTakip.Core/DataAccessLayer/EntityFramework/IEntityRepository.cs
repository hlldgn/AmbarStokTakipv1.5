using DOGAN.AmbarStokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        int EntityCount(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
