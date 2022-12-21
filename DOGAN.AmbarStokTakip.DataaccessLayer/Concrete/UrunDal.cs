using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Data.Context;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Concrete
{
    public class UrunDal : EntityRepositoryBase<Urun, AmbarStokTakipContext>, IUrunDal
    {
        public List<UrunDtoSelect> GetUrunDetailsUrunAdiBirim(Expression<Func<Urun, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Urun>().Where(filter).Select(x => new UrunDtoSelect
                {
                    Id = x.Id,
                    UrunAdi = x.UrunAdi,
                    Birim = x.Birim,
                }).ToList();
            }
        }

        public List<UrunDtoSelect> GetUrunDetailsUrunAdiBirim(Expression<Func<Urun, bool>> filter, Expression<Func<Urun, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Urun>().Where(contains).Where(filter).Select(x => new UrunDtoSelect
                {
                    Id = x.Id,
                    UrunAdi = x.UrunAdi,
                    Birim = x.Birim,
                }).ToList();
            }
        }

        public List<UrunDtoSelectWitKalori> GetUrundetailsUrunAdiBirimKalori(Expression<Func<Urun, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Urun>().Where(filter).Select(x => new UrunDtoSelectWitKalori
                {
                    Id = x.Id,
                    UrunAdi = x.UrunAdi,
                    Birim = x.Birim,
                    Kalori=x.Kalori,
                }).OrderBy(x=>x.UrunAdi).ToList();
            }
        }

        public List<UrunDtoSelectWitKalori> GetUrundetailsUrunAdiBirimKalori(Expression<Func<Urun, bool>> filter, Expression<Func<Urun, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Urun>().Where(contains).Where(filter).Select(x => new UrunDtoSelectWitKalori
                {
                    Id = x.Id,
                    UrunAdi = x.UrunAdi,
                    Birim = x.Birim,
                    Kalori = x.Kalori,
                }).OrderBy(x => x.UrunAdi).ToList();
            }
        }
    }
}
