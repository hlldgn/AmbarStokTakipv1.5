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
    public class DepoDal : EntityRepositoryBase<Depo, AmbarStokTakipContext>, IDepoDal
    {
        public List<DepoDtoSelect> GetDepoDetails(Expression<Func<Depo, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Depo>().Where(filter).Select(x => new DepoDtoSelect
                {
                    Id = x.Id,
                    DepoAdi = x.DepoAdi,
                }).ToList();
            }
        }
    }
}
