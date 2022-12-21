using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IPersonelService:IBaseService<Personel>
    {
        IDataResult<List<PersonelDtoSelect>> GetPersonelDetailsNotDeleted();
        IResult AddonDto(PersonelDtoAdd personelDtoAdd);
        IResult UpdateDeleteForUser(long id);
        IDataResult<PersonelDtoSelect> GetPersonelDetailsById(long id);
    }
}
