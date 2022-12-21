using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel>
    {
        List<PersonelDtoSelect> GetPersonelDetails(Expression<Func<Personel, bool>> filter);
        PersonelDtoSelect GetPersonel(Expression<Func<Personel, bool>> filter);
    }
}
