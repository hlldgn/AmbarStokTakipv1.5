using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IDepoService:IBaseService<Depo>
    {
        IDataResult<List<DepoDtoSelect>> GetDepoDetailsNotDeleted();
        IResult AddonDto(DepoDtoAdd depoDtoAdd);
        IResult UpdateDeleteForUser(long id);
    }
}

