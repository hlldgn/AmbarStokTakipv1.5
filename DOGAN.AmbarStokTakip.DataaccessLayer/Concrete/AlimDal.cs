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
    public class AlimDal : EntityRepositoryBase<Alim, AmbarStokTakipContext>, IAlimDal
    {
        public List<AlimDtoFilterSelect> GetAlimDetailsFilterWhereAndContains()
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Alim>().Select(x => new AlimDtoFilterSelect
                {
                    Id = x.Id,
                    AlimAdi = x.AlimAdi,
                    AlimTarihi = x.AlimTarihi,
                    AlimTuru = x.AlimTuru,
                    ProgramDeleted = x.ProgramDeleted,
                    UserDeleted = x.UserDeleted,
                }).ToList();
            }
        }

        public List<AlimDtoSelect> GetAlimDetailsWhereAndContains(Expression<Func<Alim, bool>> filter, string contains)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Alim>().Where(x=>x.AlimAdi.Contains(contains)).Where(filter).Select(x => new AlimDtoSelect
                {
                    Id = x.Id,
                    AlimAdi = x.AlimAdi,
                    AlimTuru = x.AlimTuru,
                    AlimTarihi = x.AlimTarihi,
                }).ToList();
            }
        }
        public List<AlimDtoSelect> GetAlimDetailsWhereAndContains(Expression<Func<Alim, bool>> filter)
        {
            return GetAlimDetailsWhereAndContains(filter, string.Empty);
        }

        public Alim NotDeletedLastOrDefault(Expression<Func<Alim, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Alim>().OrderByDescending(x => x.Id).FirstOrDefault(filter);
            }
        }
    }
}

