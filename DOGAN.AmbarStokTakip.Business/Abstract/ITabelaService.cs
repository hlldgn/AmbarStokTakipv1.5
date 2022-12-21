using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface ITabelaService:IBaseService<Tabela>
    {
        IResult AddonDto(TabelaDtoAdd tabelaDtoAdd);
        IDataResult<List<TabelaDtoSelect>> GetTabelaDetailsTarihNotDeleted(DateTime tabelaTarih);
        IResult AyniTarihTabelaKayitKontrol(DateTime tabelaTarih);
        IResult UpdateDeleteForUser(long id);
        IDataResult<List<TabelaDtoSelect>> SelectTabelaDetailsNotDeleted();
        IDataResult<List<TabelaDtoSelect>> SelectTabelaDetailsNotDeleted(DateTime baslangic, DateTime bitis);

    }
}
