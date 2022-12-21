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
    public class OtomatikCikisDal : EntityRepositoryBase<OtomatikCikis, AmbarStokTakipContext>, IOtomatikCikisDal
    {
        public List<OtomatikCikisDtoSelect> GetOtomatikCikisDetails(Expression<Func<OtomatikCikis, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<OtomatikCikis>().Where(filter).Select(x => new OtomatikCikisDtoSelect
                {
                    Id = x.Id,
                    UrunAdi = x.Urun.UrunAdi,
                    Birim = x.Urun.Birim,
                    sabahCikis = x.sabahCikis,
                    ogleCikis = x.ogleCikis,
                    aksamCikis = x.aksamCikis,
                    secim = x.secim == true ? "Her İaşede Çıkışı Yapılacak" : "Seçimi Bana Bırak",
                }).ToList();
            }
        }
    }
}
