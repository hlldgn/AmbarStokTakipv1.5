using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface ICikisSarfService:IBaseService<CikisSarf>
    {
        IResult AddOnDto(CikisSarfDtoAdd cikisSarfDtoAdd);
        IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetailByTarih(DateTime tarih);
        IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetailByTarih(DateTime tarih, string ara);
        IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetails();
        IResult UpdateDeleteForUser(long cikisSarfId);
    }
}
