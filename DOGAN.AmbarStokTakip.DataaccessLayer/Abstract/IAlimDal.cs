using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IAlimDal : IEntityRepository<Alim>
    {
        Alim NotDeletedLastOrDefault(Expression<Func<Alim, bool>> filter);
        List<AlimDtoSelect> GetAlimDetailsWhereAndContains(Expression<Func<Alim, bool>> filter, string contains);
        List<AlimDtoSelect> GetAlimDetailsWhereAndContains(Expression<Func<Alim, bool>> filter);
        List<AlimDtoFilterSelect> GetAlimDetailsFilterWhereAndContains();
    }
}
