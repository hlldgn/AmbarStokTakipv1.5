using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IBirimDal : IEntityRepository<Birim>
    {
        List<BirimDtoSelect> GetBirimDetails(Expression<Func<Birim, bool>> filter);
    }
}
