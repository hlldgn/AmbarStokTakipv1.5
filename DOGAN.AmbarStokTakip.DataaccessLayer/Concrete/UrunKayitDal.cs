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
    public class UrunKayitDal : EntityRepositoryBase<UrunKayit, AmbarStokTakipContext>, IUrunKayitDal
    {
        public UrunKayitDtoSelectForIase GetByUrunKayitDetailsForIase(Expression<Func<UrunKayit,bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(filter).Select(x => new UrunKayitDtoSelectForIase
                {
                    Id = x.Id,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    Kalori = x.AlimUrun.Urun.Kalori,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).FirstOrDefault();
            }
        }

        public UrunKayitDtoSelectForIaseDus GetByUrunKayitDetailsForIaseDus(long urunKayitId)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                var result = from k in context.UrunKayit
                             where k.Id == urunKayitId
                             select new UrunKayitDtoSelectForIaseDus
                             {
                                 UrunId = k.AlimUrun.Urun.Id,
                                 UrunAdi = k.AlimUrun.Urun.UrunAdi,
                                 Birim = k.AlimUrun.Urun.Birim,
                                 BirimFiyat = k.AlimUrun.BirimFiyat,
                                 MiktarKalan = k.MiktarKalan,
                                 Kalori = k.AlimUrun.Urun.Kalori
                             };
                return result.First();
            }
        }

        public List<UrunKayitDtoSelectForDepo> GetOrSearchUrunKayitDetailsForDepo(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(contains).Where(filter).Select(x => new UrunKayitDtoSelectForDepo
                {
                    Id = x.Id,                    
                    AlimId=x.AlimUrun.AlimId,
                    AlimUrunId=x.AlimUrunId,
                    DepoId=x.DepoId,
                    IaseOrSarf = x.AlimUrun.Urun.IaseOrSarf,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    AlinanMiktar=x.Miktar,
                    KalanMiktar = x.MiktarKalan,
                    ToplamTutar=x.MiktarKalan*x.AlimUrun.BirimFiyat,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                    TedarikciFirma=x.AlimUrun.TedarikciFirma,
                    Fatura = x.FaturaDurum==true?"Fatura Kesilmiş":"Fatura Kesilmemiş",
                    Odeme = x.OdemeDurum==true?"Odeme Yapılmış":"Odeme Yapılmamış",
                    ProgramDeleted = x.ProgramDeleted,
                    UserDeleted=x.UserDeleted,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForDepo> GetOrSearchUrunKayitDetailsForDepo(Expression<Func<UrunKayit, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(filter).Select(x => new UrunKayitDtoSelectForDepo
                {
                    Id = x.Id,
                    AlimId=x.AlimUrun.AlimId,
                    AlimUrunId=x.AlimUrunId,
                    DepoId=x.DepoId,
                    IaseOrSarf = x.AlimUrun.Urun.IaseOrSarf,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    AlinanMiktar=x.Miktar,
                    KalanMiktar = x.MiktarKalan,
                    ToplamTutar=x.MiktarKalan*x.AlimUrun.BirimFiyat,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    Fatura = x.FaturaDurum==true?"Fatura Kesilmiş":"Fatura Kesilmemiş",
                    Odeme = x.OdemeDurum==true?"Odeme Yapılmış":"Odeme Yapılmamış",
                    ProgramDeleted = x.ProgramDeleted,
                    UserDeleted = x.UserDeleted,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelect> GetOrSearchUrunKayitDetailsForFaturaAndOdeme(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(contains).Where(filter).Select(x => new UrunKayitDtoSelect
                {
                    Id = x.Id,
                    AlimAdi = x.AlimUrun.Alim.AlimAdi,
                    AlimTarihi = x.AlimUrun.Alim.AlimTarihi,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    Miktar = x.Miktar,
                    ToplamTutar = x.ToplamTutar,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelect> GetOrSearchUrunKayitDetailsForFaturaAndOdeme(Expression<Func<UrunKayit, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(filter).Select(x => new UrunKayitDtoSelect
                {
                    Id = x.Id,
                    AlimAdi = x.AlimUrun.Alim.AlimAdi,
                    AlimTarihi = x.AlimUrun.Alim.AlimTarihi,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    Miktar = x.Miktar,
                    ToplamTutar = x.ToplamTutar,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForIase> GetOrSearchUrunKayitDetailsForIase(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(contains).Where(filter).Select(x => new UrunKayitDtoSelectForIase
                {
                    Id = x.Id,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    Kalori = x.AlimUrun.Urun.Kalori,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForIase> GetOrSearchUrunKayitDetailsForIase(Expression<Func<UrunKayit, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(filter).Select(x => new UrunKayitDtoSelectForIase
                {
                    Id = x.Id,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    Kalori = x.AlimUrun.Urun.Kalori,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForSarf> GetOrSearchUrunKayitDetailsForSarf(Expression<Func<UrunKayit, bool>> filter, Expression<Func<UrunKayit, bool>> contains)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(contains).Where(filter).Select(x => new UrunKayitDtoSelectForSarf
                {
                    Id = x.Id,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForSarf> GetOrSearchUrunKayitDetailsForSarf(Expression<Func<UrunKayit, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Where(filter).Select(x => new UrunKayitDtoSelectForSarf
                {
                    Id = x.Id,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    KalanMiktar = x.MiktarKalan,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                }).ToList();
            }
        }

        public List<UrunKayitDtoSelectForDepo> GetUrunKayitDetailsForDepoAll()
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<UrunKayit>().Select(x => new UrunKayitDtoSelectForDepo
                {
                    Id = x.Id,
                    AlimId=x.AlimUrun.AlimId,
                    AlimUrunId=x.AlimUrunId,
                    DepoId=x.DepoId,
                    IaseOrSarf = x.AlimUrun.Urun.IaseOrSarf,
                    Birim = x.AlimUrun.Urun.Birim,
                    BirimFiyat = x.AlimUrun.BirimFiyat,
                    AlinanMiktar = x.Miktar,
                    KalanMiktar = x.MiktarKalan,
                    ToplamTutar=x.MiktarKalan*x.AlimUrun.BirimFiyat,
                    UrunAdi = x.AlimUrun.Urun.UrunAdi,
                    UrunKayitTarihi = x.UrunKayitTarihi,
                    TedarikciFirma = x.AlimUrun.TedarikciFirma,
                    Fatura = x.FaturaDurum == true ? "Fatura Kesilmiş" : "Fatura Kesilmemiş",
                    Odeme = x.OdemeDurum == true ? "Odeme Yapılmış" : "Odeme Yapılmamış",
                    ProgramDeleted = x.ProgramDeleted,
                    UserDeleted = x.UserDeleted,
                }).ToList();
            }
        }
    }
}
