using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IAlimUrunService:IBaseService<AlimUrun>
    {
        IResult AddonDto(AlimUrunDtoAdd alimUrunDtoAdd);
        IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetailsByIdNotDeleted(long id);
        IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetails(long id);
        IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetailsByTedarikciFirma();
        IDataResult<AlimUrunMuayeneKabulDtoSelect> GetAlimUrunMuayeneKabul(long id);
        IResult UpdateDeleteForProgram(long id,decimal miktar);
        IResult UpdateDeleteForUser(long id, decimal miktar);
        decimal GetSumAlimUrunMiktarKalan(long alimId);
        decimal GetSumAlimUrunAlinanMiktar(long alimId);
    }
}
