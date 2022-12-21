using DOGAN.AmbarStokTakip.Business.Abstract.Base;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Abstract
{
    public interface IUrunKayitService : IBaseService<UrunKayit>
    {
        IResult AddonDto(UrunKayitDtoAdd urunKayitDtoAdd);
        IDataResult<List<UrunKayitDtoSelect>> GetSelectUrunKayitNotDeletedAndFaturaNotInsert();
        IDataResult<List<UrunKayitDtoSelect>> GetSelectUrunKayitNotDeletedAndOdemeNotInsertAndFaturaInsert();
        IDataResult<List<UrunKayitDtoSelect>> SearchByUrunKayitDetailsNotDeletedAndOdemeNotInsertAndFaturaInsert(string ara);
        IDataResult<List<UrunKayitDtoSelect>> SearchByUrunKayitDetailsNotDeletedAndFaturaNotInsert(string ara);
        IDataResult<List<UrunKayitDtoSelectForIase>> SearchByUrunKayitDetailsForIaseNotDeleted(string ara,DateTime tarih);
        IDataResult<List<UrunKayitDtoSelectForIase>> GetUrunKayitSelectForIaseNotDeleted(DateTime tarih);
        IResult UpdateDeleteForProgram(long Id, bool fatura, bool odeme);
        IResult UpdateForFatura(long Id, bool fatura);
        IResult UpdateForOdeme(long Id, bool odeme);
        IResult UpdateDeleteForIaseIptal(long Id, decimal kalanMiktar);
        IResult UpdateDepoTransfer(long kaynakDepoId, long hedefDepoId);
        IResult UpdateForIaseOrSarf(long urunKayitId, decimal dusulenMiktar);
        IResult DeleteForUser(long urunKayitId);
        IResult IlkUrunKayitCıkısKontrol(DateTime urunKayitTarih, string urunAdi);
        IDataResult<UrunKayitDtoSelectForIaseDus> GetUrunKayitDetailsForIaseDus(long urunKayitId);
        IDataResult<UrunKayitDtoSelectForIase> GetUrunKayitDetailsForOtomatikCikisUrunId(long urunId);
        IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsNotDeletedForDepoDepoId(long Id);
        IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsNotDeletedForDepoDepoId(long Id, string contains);
        IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsAll();
        IDataResult<List<UrunKayitDtoSelectForSarf>> GetUrunKayitDetalisForSarfNotDeleted(DateTime tarih);
        IDataResult<List<UrunKayitDtoSelectForSarf>> SearchUrunKayitDetailsForSarfNotDeleted(string ara, DateTime tarih);

    }
}
