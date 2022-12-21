using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IOdemeDal:IEntityRepository<Odeme>
    {
        List<OdemeDtoSelect> GetorSearchOdemeDetails(Expression<Func<Odeme, bool>> filter);
        List<OdemeDtoSelect> GetorSearchOdemeDetails(Expression<Func<Odeme, bool>> filter, Expression<Func<Odeme, bool>> contains);
    }
}
