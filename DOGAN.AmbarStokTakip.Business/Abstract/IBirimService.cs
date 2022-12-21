using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IBirimService:IBaseService<Birim>
    {
        IResult UpdateDeleteForUser(long id);
        IResult AddonDto(BirimDtoAdd birimDtoAdd);
        IDataResult<List<BirimDtoSelect>> GetBirimDetailsNotDeleted();
    }
}
