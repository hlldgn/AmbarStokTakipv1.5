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
    public class BirimDal : EntityRepositoryBase<Birim, AmbarStokTakipContext>, IBirimDal
    {
        public List<BirimDtoSelect> GetBirimDetails(Expression<Func<Birim, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Birim>().Where(filter).Select(x => new BirimDtoSelect
                {
                    Id = x.Id,
                    BirimAdi = x.BirimAdi,
                }).OrderBy(x=>x.BirimAdi).ToList();
            }
        }
    }
}
