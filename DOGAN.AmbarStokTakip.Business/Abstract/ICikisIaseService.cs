using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface ICikisIaseService : IBaseService<CikisIase>
    {
        IResult AddonDto(CikisIaseDtoAdd cikisIaseDtoAdd);
        int CikisIaseKayitKontrol(DateTime tarih);
        IDataResult<List<CikisIaseDtoSelect>> GetCikisIaseDetailsNotDeleted(DateTime cikisIaseTarih);
        IDataResult<List<CikisIaseDtoSelect>> GetCikisIaseDetailsDeleted(DateTime cikisIaseTarih);
        IResult UpdateDeleteForUser(long Id);
        IResult UpdateDeleteForIaseIptal(CikisIaseDtoSelect cikisIaseDtoSelect);
    }
}
