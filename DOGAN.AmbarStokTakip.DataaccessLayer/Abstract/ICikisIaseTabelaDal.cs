using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface ICikisIaseTabelaDal:IEntityRepository<CikisIaseTabela>
    {
        List<CikisIaseTabelaDtoSelect> GetCikisIaseTabelaDetails(Expression<Func<CikisIaseTabela, bool>> filter);
        List<CikisIaseTabelaDtoSelectForCikisHareket> GetCikisIaseTabelaDetailsForCikisHareket(Expression<Func<CikisIaseTabela, bool>> filter);
    }
}
