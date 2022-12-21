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
    public class CikisIaseTabelaManager : ICikisIaseTabelaService
    {
        ICikisIaseTabelaDal _cikisIaseTabelaDal;
        public CikisIaseTabelaManager(ICikisIaseTabelaDal cikisIaseTabelaDal)
        {
            _cikisIaseTabelaDal = cikisIaseTabelaDal;
        }
        public IResult AddonDto(CikisIaseTabelaDtoAdd cikisIaseTabelaDtoAdd)
        {
            if (cikisIaseTabelaDtoAdd.CikisIaseId != 0 && cikisIaseTabelaDtoAdd.UrunKayitId != 0 && cikisIaseTabelaDtoAdd.Miktar > 0)
            {

                var cikisIaseTabela = new CikisIaseTabela
                {
                    CikisIaseId = cikisIaseTabelaDtoAdd.CikisIaseId,
                    Miktar = cikisIaseTabelaDtoAdd.Miktar,
                    UrunKayitId = cikisIaseTabelaDtoAdd.UrunKayitId,
                    Ogun = cikisIaseTabelaDtoAdd.Ogun,
                    KisiBasiKalori = cikisIaseTabelaDtoAdd.KisiBasiKalori,
                    KisiBasiFiyat = cikisIaseTabelaDtoAdd.KisiBasiFiyat,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    UserDeleted = false,
                };
                _cikisIaseTabelaDal.Add(cikisIaseTabela);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
        }

        public IResult Delete(long id)
        {
            var cikisIaseTabelaList = _cikisIaseTabelaDal.GetAll(x => x.CikisIaseId == id);
            foreach (var item in cikisIaseTabelaList)
            {
                _cikisIaseTabelaDal.Delete(item);
            }
            return new SuccessResult();
        }

        public IDataResult<CikisIaseTabela> GetById(long id)
        {
            return new SuccessDataResult<CikisIaseTabela>(_cikisIaseTabelaDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CikisIaseTabelaDtoSelect>> GetCikisIaseTabelaDetails(long cikisIaseId)
        {
            return new SuccessDataResult<List<CikisIaseTabelaDtoSelect>>(_cikisIaseTabelaDal.GetCikisIaseTabelaDetails(x => x.CikisIaseId == cikisIaseId));
        }

        public IDataResult<List<CikisIaseTabelaDtoSelectForCikisHareket>> GetCikisIaseTabelaDetailsForCikisHareket()
        {
            return new SuccessDataResult<List<CikisIaseTabelaDtoSelectForCikisHareket>>(_cikisIaseTabelaDal.GetCikisIaseTabelaDetailsForCikisHareket(x => x.UserDeleted == false));
        }

        public IDataResult<List<CikisIaseTabela>> NotDeleted()
        {
            return new SuccessDataResult<List<CikisIaseTabela>>(_cikisIaseTabelaDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long Id)
        {
            try
            {
                var oldEntity = _cikisIaseTabelaDal.Get(x => x.Id == Id);
                var cikisTabelaIase = new CikisIaseTabela
                {
                    Id = Id,
                    CreateDate = oldEntity.CreateDate,
                    UrunKayitId = oldEntity.UrunKayitId,
                    CikisIaseId = oldEntity.CikisIaseId,
                    KisiBasiFiyat = oldEntity.KisiBasiFiyat,
                    KisiBasiKalori = oldEntity.KisiBasiKalori,
                    Miktar = oldEntity.Miktar,
                    Ogun = oldEntity.Ogun,
                    UpdateDate = DateTime.Now,
                    UserDeleted = true,
                };
                _cikisIaseTabelaDal.Update(cikisTabelaIase);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
