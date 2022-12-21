using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface ICikisIaseTabelaService:IBaseService<CikisIaseTabela>
    {
        IResult AddonDto(CikisIaseTabelaDtoAdd cikisIaseTabelaDtoAdd);
        IResult Delete(long id);
        IDataResult<List<CikisIaseTabelaDtoSelect>> GetCikisIaseTabelaDetails(long cikisIaseId);
        IResult UpdateDeleteForUser(long Id);
        IDataResult<List<CikisIaseTabelaDtoSelectForCikisHareket>> GetCikisIaseTabelaDetailsForCikisHareket();
    }
}
