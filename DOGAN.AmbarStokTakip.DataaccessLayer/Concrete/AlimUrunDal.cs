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
    public class AlimUrunDal : EntityRepositoryBase<AlimUrun, AmbarStokTakipContext>, IAlimUrunDal
    {
        public AlimUrunMuayeneKabulDtoSelect GetAlimUrun(Expression<Func<AlimUrun, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<AlimUrun>().Where(filter).Select(x => new AlimUrunMuayeneKabulDtoSelect
                {
                    UrunAdi = x.Urun.UrunAdi,
                    Birim = x.Urun.Birim,
                    BirimFiyat = x.BirimFiyat,
                    BirimFiyatKdvHaric = x.BirimFiyatKDVHaric,
                    Kdv = x.Kdv,
                    TedarikciFirma = x.TedarikciFirma,
                }).FirstOrDefault();
            }
        }

        public List<AlimUrunDtoSelect> GetAlimUrunDetails(Expression<Func<AlimUrun, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<AlimUrun>().Where(filter).Select(x=> new AlimUrunDtoSelect
                {
                    Id = x.Id,
                    AlimId = x.AlimId,
                    AlimAdi = x.Alim.AlimAdi,
                    UrunAdi = x.Urun.UrunAdi,
                    Birim = x.Urun.Birim,
                    BirimFiyat = x.BirimFiyat,
                    AlinanMiktar = x.Miktar,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.TedarikciFirma,
                }).ToList();
            }
        }

        public decimal GetToplamDoubleFilter(Expression<Func<AlimUrun, bool>> filter, Expression<Func<AlimUrun, decimal>> sum)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<AlimUrun>().Where(filter).Sum(sum);
            }
        }
    }
}
