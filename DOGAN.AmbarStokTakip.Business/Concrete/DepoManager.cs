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
    public class DepoManager : IDepoService
    {
        IDepoDal _depoDal;
        public DepoManager(IDepoDal depoDal)
        {
            _depoDal = depoDal;
        }

        public IResult AddonDto(DepoDtoAdd depoDtoAdd)
        {
            if (depoDtoAdd.DepoAdi != String.Empty)
            {
                var depo = new Depo
                {
                    UserDeleted = false,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    DepoAdi = depoDtoAdd.DepoAdi,
                };
                _depoDal.Add(depo);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Depo Adı alanının doldurulması zorunludur. Lütfen bilgileri eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IDataResult<Depo> GetById(long id)
        {
            return new SuccessDataResult<Depo>(_depoDal.Get(x => x.Id == id));
        }

        public IDataResult<List<DepoDtoSelect>> GetDepoDetailsNotDeleted()
        {
            return new SuccessDataResult<List<DepoDtoSelect>>(_depoDal.GetDepoDetails(x => x.UserDeleted == false));
        }

        public IDataResult<List<Depo>> NotDeleted()
        {
            return new SuccessDataResult<List<Depo>>(_depoDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long id)
        {
            try
            {
                var oldEntity = _depoDal.Get(x => x.Id == id);
                var depo = new Depo
                {
                    Id = id,
                    DepoAdi = oldEntity.DepoAdi,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                    UserDeleted = true,
                };
                _depoDal.Update(depo);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult("İlgili depo silinirken bir hata meydana geldi. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
