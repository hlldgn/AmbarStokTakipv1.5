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
    public class BirimManager : IBirimService
    {
        IBirimDal _birimDal;
        public BirimManager(IBirimDal birimDal)
        {
            _birimDal = birimDal;
        }
        public IResult AddonDto(BirimDtoAdd birimDtoAdd)
        {
            if (birimDtoAdd.BirimAdi != String.Empty)
            {
                var birim = new Birim
                {
                    UserDeleted = false,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    BirimAdi = birimDtoAdd.BirimAdi,
                };
                _birimDal.Add(birim);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Birim adı alanının doldurulması zorunludur. Lütfen bilgileri eksiksiz doldurup tekrar deniyiniz.");
            }
        }

        public IDataResult<List<BirimDtoSelect>> GetBirimDetailsNotDeleted()
        {
            return new SuccessDataResult<List<BirimDtoSelect>>(_birimDal.GetBirimDetails(x => x.UserDeleted == false));
        }

        public IDataResult<Birim> GetById(long id)
        {
            return new SuccessDataResult<Birim>(_birimDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Birim>> NotDeleted()
        {

            return new SuccessDataResult<List<Birim>>(_birimDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long id)
        {
            try
            {
                var oldEntity = _birimDal.Get(x => x.Id == id);
                var birim = new Birim
                {
                    Id = id,
                    BirimAdi = oldEntity.BirimAdi,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                    UserDeleted = true,
                };
                _birimDal.Update(birim);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult("İlgili birim silinirken bir hata meydana geldi. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
