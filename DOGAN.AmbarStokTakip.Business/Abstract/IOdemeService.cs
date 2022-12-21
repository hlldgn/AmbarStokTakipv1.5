using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IOdemeService:IBaseService<Odeme>
    {
        IResult AddonDto(OdemeDtoAdd odemeDtoAdd);
        IDataResult<List<OdemeDtoSelect>> GetOdemeNotDeletedDetails();
        IDataResult<List<OdemeDtoSelect>> SearchOdemeNotDeletedDetails(DateTime tarih);
        IResult UpdateForUser(long Id);
    }
}
