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
    public class FaturaDal : EntityRepositoryBase<Fatura, AmbarStokTakipContext>, IFaturaDal
    {
        public List<FaturaDtoSelect> GetorSearchFaturaDetails(Expression<Func<Fatura, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Fatura>().Where(filter).Select(x => new FaturaDtoSelect
                {
                    Id = x.Id,
                    UrunKayitId=x.UrunKayitId,
                    AlimAdi = x.UrunKayit.AlimUrun.Alim.AlimAdi,
                    AlimTarihi = x.UrunKayit.AlimUrun.Alim.AlimTarihi,
                    Birim = x.UrunKayit.AlimUrun.Urun.Birim,
                    BirimFiyat = x.UrunKayit.AlimUrun.BirimFiyat,
                    Miktar = x.UrunKayit.Miktar,
                    TedarikciFirma = x.UrunKayit.AlimUrun.TedarikciFirma,
                    ToplamTutar = x.UrunKayit.ToplamTutar,
                    UrunAdi = x.UrunKayit.AlimUrun.Urun.UrunAdi,
                    UrunKayitTarihi = x.UrunKayit.UrunKayitTarihi,
                    FaturaTarihi = x.FaturaTarihi,
                    
                }).ToList();
            }
        }

        public List<FaturaDtoSelect> GetorSearchFaturaDetails(Expression<Func<Fatura, bool>> filter, Expression<Func<Fatura, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Fatura>().Where(contains).Where(filter).Select(x => new FaturaDtoSelect
                {
                    Id = x.Id,
                    UrunKayitId = x.UrunKayitId,
                    AlimAdi = x.UrunKayit.AlimUrun.Alim.AlimAdi,
                    AlimTarihi = x.UrunKayit.AlimUrun.Alim.AlimTarihi,
                    Birim = x.UrunKayit.AlimUrun.Urun.Birim,
                    BirimFiyat = x.UrunKayit.AlimUrun.BirimFiyat,
                    Miktar = x.UrunKayit.Miktar,
                    TedarikciFirma = x.UrunKayit.AlimUrun.TedarikciFirma,
                    ToplamTutar = x.UrunKayit.ToplamTutar,
                    UrunAdi = x.UrunKayit.AlimUrun.Urun.UrunAdi,
                    UrunKayitTarihi = x.UrunKayit.UrunKayitTarihi,
                    FaturaTarihi = x.FaturaTarihi,

                }).ToList();
            }
        }
    }
}
