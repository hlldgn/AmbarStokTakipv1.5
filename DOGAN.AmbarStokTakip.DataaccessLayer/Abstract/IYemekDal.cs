using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IYemekDal : IEntityRepository<Yemek>
    {
        List<YemekDtoSelect> GetYemekDetails();
    }
}
