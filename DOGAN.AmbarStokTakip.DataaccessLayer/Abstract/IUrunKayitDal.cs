using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IUrunKayitDal : IEntityRepository<UrunKayit>
    {
        List<UrunKayitDtoSelect> GetOrSearchUrunKayitDetailsForFaturaAndOdeme(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains);
        List<UrunKayitDtoSelect> GetOrSearchUrunKayitDetailsForFaturaAndOdeme(Expression<Func<UrunKayit, bool>> filter);
        List<UrunKayitDtoSelectForIase> GetOrSearchUrunKayitDetailsForIase(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains);
        List<UrunKayitDtoSelectForIase> GetOrSearchUrunKayitDetailsForIase(Expression<Func<UrunKayit, bool>> filter);
        UrunKayitDtoSelectForIaseDus GetByUrunKayitDetailsForIaseDus(long urunKayitId);
        UrunKayitDtoSelectForIase GetByUrunKayitDetailsForIase(Expression<Func<UrunKayit, bool>> filter);
        List<UrunKayitDtoSelectForDepo> GetOrSearchUrunKayitDetailsForDepo(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains);
        List<UrunKayitDtoSelectForDepo> GetOrSearchUrunKayitDetailsForDepo(Expression<Func<UrunKayit, bool>> filter);
        List<UrunKayitDtoSelectForDepo> GetUrunKayitDetailsForDepoAll();
        List<UrunKayitDtoSelectForSarf> GetOrSearchUrunKayitDetailsForSarf(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains);
        List<UrunKayitDtoSelectForSarf> GetOrSearchUrunKayitDetailsForSarf(Expression<Func<UrunKayit, bool>> filter);
    }
}
