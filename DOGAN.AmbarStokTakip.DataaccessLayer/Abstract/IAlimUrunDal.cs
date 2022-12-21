using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Abstract
{
    public interface IAlimUrunDal:IEntityRepository<AlimUrun>
    {
        List<AlimUrunDtoSelect> GetAlimUrunDetails(Expression<Func<AlimUrun,bool>> filter);
        AlimUrunMuayeneKabulDtoSelect GetAlimUrun(Expression<Func<AlimUrun, bool>> filter);
        decimal GetToplamDoubleFilter(Expression<Func<AlimUrun, bool>> filter, Expression<Func<AlimUrun, decimal>> sum);
    }
}
