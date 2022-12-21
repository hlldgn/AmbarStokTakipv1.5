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
    public class OdemeManager : IOdemeService
    {
        IOdemeDal _odemeDal;
        public OdemeManager(IOdemeDal odemeDal)
        {
            _odemeDal = odemeDal;
        }

        public IResult AddonDto(OdemeDtoAdd odemeDtoAdd)
        {
            var odeme = new Odeme
            {
                OdemeTarihi = odemeDtoAdd.OdemeTarihi,
                UrunKayitId = odemeDtoAdd.UrunKayitId,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                UserDeleted = false,
            };
            _odemeDal.Add(odeme);
            return new SuccessResult();
        }

        public IDataResult<Odeme> GetById(long id)
        {
            return new SuccessDataResult<Odeme>(_odemeDal.Get(x => x.Id == id));
        }

        public IDataResult<List<OdemeDtoSelect>> GetOdemeNotDeletedDetails()
        {
            return new SuccessDataResult<List<OdemeDtoSelect>>(_odemeDal.GetorSearchOdemeDetails(x => x.UserDeleted == false));
        }

        public IDataResult<List<Odeme>> NotDeleted()
        {
            return new SuccessDataResult<List<Odeme>>(_odemeDal.GetAll(x => x.UserDeleted == false));
        }

        public IDataResult<List<OdemeDtoSelect>> SearchOdemeNotDeletedDetails(DateTime tarih)
        {
            return new SuccessDataResult<List<OdemeDtoSelect>>(_odemeDal.GetorSearchOdemeDetails(x => x.UserDeleted == false, x => x.OdemeTarihi == tarih));
        }

        public IResult UpdateForUser(long Id)
        {
            try
            {
                var oldEntity = _odemeDal.Get(x => x.Id == Id);
                var odeme = new Odeme
                {
                    Id = Id,
                    CreateDate = oldEntity.CreateDate,
                    OdemeTarihi = oldEntity.OdemeTarihi,
                    UpdateDate = DateTime.Now,
                    UrunKayitId = oldEntity.UrunKayitId,
                    UserDeleted = true,
                };
                _odemeDal.Update(odeme);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }
    }
}
