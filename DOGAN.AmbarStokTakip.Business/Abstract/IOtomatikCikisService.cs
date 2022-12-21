using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IOtomatikCikisService:IBaseService<OtomatikCikis>
    {
        IResult AddonDTo(OtomatikCikisDtoAdd otomatikCikisDtoAdd);
        IDataResult<List<OtomatikCikisDtoSelect>> GetSelectOtomatikCikisDetailsNotDeleted();
        IDataResult<OtomatikCikis> GetByOtomatikCikisDetailsUrunIdSecimiBanaBirak(long urunId);
        IResult GetAyniIsimliUrunKaydiKontrol(long urunId);
        IResult UpdateDeleteForUser(long id);
        IDataResult<List<OtomatikCikis>> GetOtomatikCikisDetailNotDeletedAndHerIase();
    }
}
