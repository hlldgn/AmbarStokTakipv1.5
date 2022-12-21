using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;

namespace DOGAN.AmbarStokTakip.Business.Concrete
{
    public class TabelaManager : ITabelaService
    {
        ITabelaDal _tabelaDal;
        public TabelaManager(ITabelaDal tabelaDal)
        {
            _tabelaDal = tabelaDal;
        }

        public IResult AddonDto(TabelaDtoAdd tabelaDtoAdd)
        {
            if (tabelaDtoAdd.Sabah != String.Empty && tabelaDtoAdd.Ogle != String.Empty && tabelaDtoAdd.Aksam != String.Empty && tabelaDtoAdd.TabelaTarihi != null)
            {
                var tabela = new Tabela
                {
                    UserDeleted = false,
                    Sabah = tabelaDtoAdd.Sabah,
                    Ogle = tabelaDtoAdd.Ogle,
                    Aksam = tabelaDtoAdd.Aksam,
                    TabelaTarihi = tabelaDtoAdd.TabelaTarihi,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };
                _tabelaDal.Add(tabela);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Tabela ekleme alanları gerektiği gibi doldurulmamış. Lütfen istenilen bilgileri eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IResult AyniTarihTabelaKayitKontrol(DateTime tabelaTarih)
        {
            int kayitsayisi = _tabelaDal.AyniTarihTabelaKayitKontrol(tabelaTarih);
            if (kayitsayisi <= 0)
            {
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Bu tarihe kayıtlı bir program vardır lütfen başka tarih seçiniz veya bu kaydı siliniz.");
            }
        }

        public IDataResult<Tabela> GetById(long id)
        {
            return new SuccessDataResult<Tabela>(_tabelaDal.Get(x => x.Id == id));
        }

        public IDataResult<List<TabelaDtoSelect>> GetTabelaDetailsTarihNotDeleted(DateTime tabelaTarih)
        {
            return new SuccessDataResult<List<TabelaDtoSelect>>(_tabelaDal.GetTabelaDetails(x => x.UserDeleted == false && x.TabelaTarihi == tabelaTarih));
        }

        public IDataResult<List<Tabela>> NotDeleted()
        {
            return new SuccessDataResult<List<Tabela>>(_tabelaDal.GetAll(x => x.UserDeleted == false));
        }

        public IDataResult<List<TabelaDtoSelect>> SelectTabelaDetailsNotDeleted(DateTime baslangic,DateTime bitis)
        {
            return new SuccessDataResult<List<TabelaDtoSelect>>(_tabelaDal.GetTabelaDetails(x => x.UserDeleted == false&&x.TabelaTarihi>=baslangic&&x.TabelaTarihi<=bitis));
        }

        public IDataResult<List<TabelaDtoSelect>> SelectTabelaDetailsNotDeleted()
        {
            return new SuccessDataResult<List<TabelaDtoSelect>>(_tabelaDal.GetTabelaDetails(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long id)
        {
            try
            {
                var oldEntity = _tabelaDal.Get(x => x.Id == id);
                var tabela = new Tabela
                {
                    Id = id,
                    UserDeleted = true,
                    Sabah = oldEntity.Sabah,
                    Ogle = oldEntity.Ogle,
                    Aksam = oldEntity.Aksam,
                    TabelaTarihi = oldEntity.TabelaTarihi,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                };
                _tabelaDal.Update(tabela);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult("İlgili tabela silinirken bir hata meydana geldi. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
