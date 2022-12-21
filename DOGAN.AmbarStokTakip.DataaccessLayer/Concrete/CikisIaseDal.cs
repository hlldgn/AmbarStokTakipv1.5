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
    public class CikisIaseDal : EntityRepositoryBase<CikisIase, AmbarStokTakipContext>, ICikisIaseDal
    {
        public List<CikisIaseDtoSelect> GetCikisIaseDetails(Expression<Func<CikisIase, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<CikisIase>().Where(filter).Select(x => new CikisIaseDtoSelect
                {
                    Id = x.Id,
                    AcikHT = x.AcikHT,
                    AclikGrevi = x.AclikGrevi,
                    AksamPer = x.AksamPer,
                    Bebek = x.Bebek,
                    CikisIaseTarihi = x.CikisIaseTarihi,
                    Cocuk = x.Cocuk,
                    Diyet = x.Diyet,
                    HamileBayan = x.HamileBayan,
                    iaseAd = x.iaseAd,
                    KapaliHT = x.KapaliHT,
                    OglePer = x.OglePer,
                    SabahPer = x.SabahPer,
                    TAksam = x.TAksam,
                    TOgle = x.TOgle,
                    TSabah = x.TSabah,
                }).ToList();
            }
        }
    }
}
