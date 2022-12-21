using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Data.Context;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;
using System.Linq;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Concrete
{
    public class YemekDal : EntityRepositoryBase<Yemek, AmbarStokTakipContext>, IYemekDal
    {
        public List<YemekDtoSelect> GetYemekDetails()
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                var result = from k in context.Yemek
                             select new YemekDtoSelect
                             {
                                 YemekAdi=k.YemekAdi,
                             };
                return result.ToList();
            }
        }
    }
}
