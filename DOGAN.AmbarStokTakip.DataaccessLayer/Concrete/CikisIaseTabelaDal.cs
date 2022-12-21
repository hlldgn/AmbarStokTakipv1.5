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
    public class CikisIaseTabelaDal : EntityRepositoryBase<CikisIaseTabela, AmbarStokTakipContext>, ICikisIaseTabelaDal
    {
        public List<CikisIaseTabelaDtoSelect> GetCikisIaseTabelaDetails(Expression<Func<CikisIaseTabela, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<CikisIaseTabela>().Where(filter).Select(x => new CikisIaseTabelaDtoSelect
                {
                    Id = x.Id,
                    UrunKayitId = x.UrunKayit.Id,
                    Ogun = x.Ogun,
                    UrunAdi = x.UrunKayit.AlimUrun.Urun.UrunAdi,
                    Birim = x.UrunKayit.AlimUrun.Urun.Birim,
                    Kalori = x.UrunKayit.AlimUrun.Urun.Kalori,
                    BirimFiyat = x.UrunKayit.AlimUrun.BirimFiyat,
                    KisiBasiFiyat = x.KisiBasiFiyat,
                    KisiBasiKalori = x.KisiBasiKalori,
                    Miktar = x.Miktar,
                }).ToList();
            }
        }

        public List<CikisIaseTabelaDtoSelectForCikisHareket> GetCikisIaseTabelaDetailsForCikisHareket(Expression<Func<CikisIaseTabela, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<CikisIaseTabela>().Where(filter).Select(x => new CikisIaseTabelaDtoSelectForCikisHareket
                {
                    Id = x.Id,
                    Birim = x.UrunKayit.AlimUrun.Urun.Birim,
                    UrunAdi = x.UrunKayit.AlimUrun.Urun.UrunAdi,
                    Miktar = x.Miktar,
                    BirimFiyat = x.UrunKayit.AlimUrun.BirimFiyat,
                    CikisTarihi = x.CikisIase.CikisIaseTarihi,
                    Kalori = x.UrunKayit.AlimUrun.Urun.Kalori,
                    ToplamTutar = x.Miktar * x.UrunKayit.AlimUrun.BirimFiyat,
                    UrunKayitId = x.UrunKayitId
                }).ToList();
            }
        }
    }
}
