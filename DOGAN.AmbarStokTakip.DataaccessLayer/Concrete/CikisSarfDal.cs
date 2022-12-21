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
    public class CikisSarfDal : EntityRepositoryBase<CikisSarf, AmbarStokTakipContext>, ICikisSarfDal
    {
        public List<CikisSarfDtoSelect> GetCikisSarfDetail(Expression<Func<CikisSarf, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<CikisSarf>().Where(filter).Select(x => new CikisSarfDtoSelect
                {
                    Id = x.Id,
                    UrunKayitId=x.UrunKayitId,
                    UrunAdi = x.UrunKayit.AlimUrun.Urun.UrunAdi,
                    Birim = x.UrunKayit.AlimUrun.Urun.Birim,
                    BirimFiyat = x.UrunKayit.AlimUrun.BirimFiyat,
                    CikisTarihi = x.CikisSarfTarihi,
                    TeslimEdilenBirim = x.Birim.BirimAdi,
                    TeslimEdilenKisi = x.APersonel.PersonelAdi + " " + x.APersonel.PersonelSoyadi,
                    Miktar = x.Miktar,
                    ToplamTutar = x.Miktar * x.UrunKayit.AlimUrun.BirimFiyat,
                }).ToList();
            }
        }
    }
}
