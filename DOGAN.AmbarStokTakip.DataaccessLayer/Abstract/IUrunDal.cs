using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IUrunDal:IEntityRepository<Urun>
    {
        List<UrunDtoSelect> GetUrunDetailsUrunAdiBirim(Expression<Func<Urun,bool>>filter);
        List<UrunDtoSelect> GetUrunDetailsUrunAdiBirim(Expression<Func<Urun, bool>> filter, Expression<Func<Urun, bool>> contains);
        List<UrunDtoSelectWitKalori> GetUrundetailsUrunAdiBirimKalori(Expression<Func<Urun, bool>> filter);
        List<UrunDtoSelectWitKalori> GetUrundetailsUrunAdiBirimKalori(Expression<Func<Urun, bool>> filter, Expression<Func<Urun, bool>> contains);
    }
}
