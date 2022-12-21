using DOGAN.AmbarStokTakip.Core.Entities;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract.Base
{
    public interface IBaseService<TEntity> where TEntity : class,IEntity,new()
    {
        IDataResult<List<TEntity>> NotDeleted();
        IDataResult<TEntity> GetById(long id);
    }
}
