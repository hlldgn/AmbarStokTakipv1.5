using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IFaturaDal:IEntityRepository<Fatura>
    {
        List<FaturaDtoSelect> GetorSearchFaturaDetails(Expression<Func<Fatura, bool>> filter);
        List<FaturaDtoSelect> GetorSearchFaturaDetails(Expression<Func<Fatura, bool>> filter, Expression<Func<Fatura, bool>> contains);
    }
}
