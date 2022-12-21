using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IAlimService:IBaseService<Alim>
    {
        IDataResult<List<AlimDtoSelect>> SearchAlimDetailsNotDeleted(string alimAdi);
        IDataResult<List<AlimDtoSelect>> GetAlimDetailsNotDeleted();
        IResult AddonDto(AlimDtoAdd alimDtoAdd);
        IResult UpdateDelete(long Id, bool programDeleted, bool userDeleted);
        IDataResult<List<AlimDtoFilterSelect>> GetAlimDetailsAllAlim();

    }

}
