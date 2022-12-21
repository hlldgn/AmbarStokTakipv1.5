using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface ITelefonRehberDal : IEntityRepository<TelefonRehber>
    {
        List<TelefonRehberDtoSelect> GetorSearchTelefonRehberDetails(Expression<Func<TelefonRehber, bool>> filter);
        List<TelefonRehberDtoSelect> GetorSearchTelefonRehberDetails(Expression<Func<TelefonRehber, bool>> filter, Expression<Func<TelefonRehber, bool>> contains);
    }
}
