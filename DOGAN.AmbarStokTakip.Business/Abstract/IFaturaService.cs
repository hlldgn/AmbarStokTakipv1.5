using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IFaturaService : IBaseService<Fatura>
    {
        IResult AddonDto(FaturaDtoAdd faturaDtoAdd);
        IDataResult<Fatura> GetFaturaUrunKayitId(long urunKayitId);
        IDataResult<List<FaturaDtoSelect>> GetFaturaNotDeletedDetails();
        IDataResult<List<FaturaDtoSelect>> SearchFaturaNotDeletedDetails(DateTime tarih);
        IResult UpdateForUser(long Id);
    }
}
