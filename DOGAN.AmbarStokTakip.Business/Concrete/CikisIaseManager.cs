using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGAN.AmbarStokTakip.Business.Concrete
{
    public class CikisIaseManager : ICikisIaseService
    {
        ICikisIaseDal _cikisIaseDal;
        public CikisIaseManager(ICikisIaseDal cikisIaseDal)
        {
            _cikisIaseDal = cikisIaseDal;
        }
        public IResult AddonDto(CikisIaseDtoAdd cikisIaseDtoAdd)
        {
            if (cikisIaseDtoAdd.CikisIaseTarihi != null && cikisIaseDtoAdd.iaseAd != String.Empty)
            {
                var cikisIase = new CikisIase
                {
                    KapaliHT = cikisIaseDtoAdd.KapaliHT,
                    AcikHT = cikisIaseDtoAdd.AcikHT,
                    SabahPer = cikisIaseDtoAdd.SabahPer,
                    OglePer = cikisIaseDtoAdd.OglePer,
                    AksamPer = cikisIaseDtoAdd.AksamPer,
                    Cocuk = cikisIaseDtoAdd.Cocuk,
                    HamileBayan = cikisIaseDtoAdd.HamileBayan,
                    Bebek = cikisIaseDtoAdd.Bebek,
                    AclikGrevi = cikisIaseDtoAdd.AclikGrevi,
                    Diyet = cikisIaseDtoAdd.Diyet,
                    TSabah = cikisIaseDtoAdd.TSabah,
                    TOgle = cikisIaseDtoAdd.TOgle,
                    TAksam = cikisIaseDtoAdd.TAksam,
                    CikisIaseTarihi = cikisIaseDtoAdd.CikisIaseTarihi,
                    iaseAd = cikisIaseDtoAdd.iaseAd,
                    TabelaId = cikisIaseDtoAdd.TabelaId,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    UserDeleted = false,
                };
                _cikisIaseDal.Add(cikisIase);
                return new SuccessResult(cikisIase.Id);
            }
            else
            {
                return new ErrorResult();
            }
        }

        public int CikisIaseKayitKontrol(DateTime tarih)
        {
            return _cikisIaseDal.GetAll(x => x.UserDeleted == false && x.CikisIaseTarihi == tarih).Count();
        }

        public IDataResult<CikisIase> GetById(long id)
        {
            return new SuccessDataResult<CikisIase>(_cikisIaseDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CikisIaseDtoSelect>> GetCikisIaseDetailsDeleted(DateTime cikisIaseTarih)
        {
            return new SuccessDataResult<List<CikisIaseDtoSelect>>(_cikisIaseDal.GetCikisIaseDetails(x => x.UserDeleted == true && x.CikisIaseTarihi == cikisIaseTarih));
        }

        public IDataResult<List<CikisIaseDtoSelect>> GetCikisIaseDetailsNotDeleted(DateTime cikisIaseTarih)
        {
            return new SuccessDataResult<List<CikisIaseDtoSelect>>(_cikisIaseDal.GetCikisIaseDetails(x => x.UserDeleted == false && x.CikisIaseTarihi == cikisIaseTarih));
        }

        public IDataResult<List<CikisIase>> NotDeleted()
        {
            return new SuccessDataResult<List<CikisIase>>(_cikisIaseDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForIaseIptal(CikisIaseDtoSelect cikisIaseDtoSelect)
        {
            try
            {
                long id = cikisIaseDtoSelect.Id;
                var oldEntity = _cikisIaseDal.Get(x => x.Id == id);
                var cikisIase = new CikisIase
                {
                    Id = id,
                    AcikHT = cikisIaseDtoSelect.AcikHT,
                    AclikGrevi = cikisIaseDtoSelect.AclikGrevi,
                    AksamPer = cikisIaseDtoSelect.AksamPer,
                    Bebek = cikisIaseDtoSelect.Bebek,
                    CikisIaseTarihi = cikisIaseDtoSelect.CikisIaseTarihi,
                    Cocuk = cikisIaseDtoSelect.Cocuk,
                    UserDeleted = false,
                    SabahPer = cikisIaseDtoSelect.SabahPer,
                    Diyet = cikisIaseDtoSelect.Diyet,
                    HamileBayan = cikisIaseDtoSelect.HamileBayan,
                    iaseAd = cikisIaseDtoSelect.iaseAd,
                    KapaliHT = cikisIaseDtoSelect.KapaliHT,
                    OglePer = cikisIaseDtoSelect.OglePer,
                    TAksam = cikisIaseDtoSelect.TAksam,
                    TOgle = cikisIaseDtoSelect.TOgle,
                    TSabah = cikisIaseDtoSelect.TSabah,
                    CreateDate = oldEntity.CreateDate,
                    TabelaId = oldEntity.TabelaId,
                    UpdateDate = DateTime.Now,
                };
                _cikisIaseDal.Update(cikisIase);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        public IResult UpdateDeleteForUser(long Id)
        {
            try
            {
                var oldEntity = _cikisIaseDal.Get(x => x.Id == Id);
                var cikisIase = new CikisIase
                {
                    AcikHT = oldEntity.AcikHT,
                    AclikGrevi = oldEntity.AclikGrevi,
                    AksamPer = oldEntity.AksamPer,
                    Bebek = oldEntity.Bebek,
                    CikisIaseTarihi = oldEntity.CikisIaseTarihi,
                    Cocuk = oldEntity.Cocuk,
                    CreateDate = oldEntity.CreateDate,
                    Diyet = oldEntity.Diyet,
                    HamileBayan = oldEntity.HamileBayan,
                    iaseAd = oldEntity.iaseAd,
                    Id = Id,
                    KapaliHT = oldEntity.KapaliHT,
                    OglePer = oldEntity.OglePer,
                    SabahPer = oldEntity.SabahPer,
                    TabelaId = oldEntity.TabelaId,
                    TAksam = oldEntity.TAksam,
                    TOgle = oldEntity.TOgle,
                    TSabah = oldEntity.TSabah,
                    UpdateDate = DateTime.Now,
                    UserDeleted = true,
                };
                _cikisIaseDal.Update(cikisIase);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
