using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IUrunService : IBaseService<Urun>
    {
        IResult AddonDto(UrunDtoAdd urunDtoAdd);
        IDataResult<List<UrunDtoSelect>> GetUrunDetailUrunAdiBirimNotDeleted();
        IDataResult<List<UrunDtoSelect>> GetUrunDetailUrunAdiBirimNotDeleted(string contains);
        IDataResult<List<UrunDtoSelectWitKalori>> GetUrunDetailWithKaloriNotDeleted();
        IDataResult<List<UrunDtoSelectWitKalori>> GetUrunDetailWithKaloriNotDeleted(string contains);
        IResult UpdateDeleteForUser(long Id);
    }
}
