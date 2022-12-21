using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface ITelefonRehberService:IBaseService<TelefonRehber>
    {
        IDataResult<List<TelefonRehberDtoSelect>> GetTelefonRehberNotDeleted();
        IDataResult<List<TelefonRehberDtoSelect>> SearchTelefonRehberNotDeleted(string ara);
        IResult AddOnDto(TelefonRehberDtoAdd telefonRehberDtoAdd);
        IResult UpdateForUser(TelefonRehberDtoSelect telefonRehberDtoSelect);
        IResult UpdateDeleteForUser(long Id);
    }
}
