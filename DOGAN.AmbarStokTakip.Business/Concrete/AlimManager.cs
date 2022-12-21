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
    public class AlimManager : IAlimService
    {
        IAlimDal _alimDal;
        public AlimManager(IAlimDal alimDal)
        {
            _alimDal = alimDal;
        }
        public IResult AddonDto(AlimDtoAdd alimDtoAdd)
        {
            if (alimDtoAdd.AlimTuru != String.Empty && alimDtoAdd.AlimAdi != String.Empty && alimDtoAdd.AlimTarihi != null)
            {
                var alim = new Alim
                {
                    AlimAdi = alimDtoAdd.AlimAdi,
                    AlimTarihi = alimDtoAdd.AlimTarihi,
                    AlimTuru = alimDtoAdd.AlimTuru,
                    UpdateDate = DateTime.Now,
                    CreateDate = DateTime.Now,
                    ProgramDeleted = false,
                    UserDeleted = false,
                };
                _alimDal.Add(alim);
                return new SuccessResult(alim.Id);
            }
            else
            {
                return new ErrorResult("Alim Bilgileri gerektiği gibi doldurulmamış. Lütfen eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IDataResult<Alim> GetById(long id)
        {
            return new SuccessDataResult<Alim>(_alimDal.Get(x => x.Id == id));
        }

        public IDataResult<List<AlimDtoSelect>> SearchAlimDetailsNotDeleted(string alimAdi)
        {
            return new SuccessDataResult<List<AlimDtoSelect>>(_alimDal.GetAlimDetailsWhereAndContains(x => x.ProgramDeleted == false && x.UserDeleted == false, alimAdi));
        }

        public IDataResult<List<AlimDtoSelect>> GetAlimDetailsNotDeleted()
        {
            return new SuccessDataResult<List<AlimDtoSelect>>(_alimDal.GetAlimDetailsWhereAndContains(x => x.UserDeleted == false && x.ProgramDeleted == false));
        }

        public IDataResult<List<Alim>> NotDeleted()
        {
            return new SuccessDataResult<List<Alim>>(_alimDal.GetAll(x => x.ProgramDeleted == false && x.UserDeleted == false));
        }

        public IResult UpdateDelete(long Id, bool programDeleted, bool userDeleted)
        {
            try
            {
                var oldEntity = _alimDal.Get(x => x.Id == Id);
                var alim = new Alim
                {
                    Id = Id,
                    AlimAdi = oldEntity.AlimAdi,
                    AlimTarihi = oldEntity.AlimTarihi,
                    AlimTuru = oldEntity.AlimTuru,
                    CreateDate = oldEntity.CreateDate,
                    ProgramDeleted = programDeleted,
                    UserDeleted = userDeleted,
                    UpdateDate = DateTime.Now,
                };
                _alimDal.Update(alim);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<AlimDtoFilterSelect>> GetAlimDetailsAllAlim()
        {
            return new SuccessDataResult<List<AlimDtoFilterSelect>>(_alimDal.GetAlimDetailsFilterWhereAndContains());
        }
    }
}
