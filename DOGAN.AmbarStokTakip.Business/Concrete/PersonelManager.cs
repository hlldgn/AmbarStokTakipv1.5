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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IResult AddonDto(PersonelDtoAdd personelDtoAdd)
        {
            if (personelDtoAdd.PersonelAdi != String.Empty && personelDtoAdd.PersonelSoyadi != String.Empty)
            {
                var personel = new Personel
                {
                    UserDeleted = false,
                    PersonelAdi = personelDtoAdd.PersonelAdi,
                    PersonelSoyadi = personelDtoAdd.PersonelSoyadi,
                    PersonelSicili = personelDtoAdd.PersonelSicili,
                    PersonelUnvani = personelDtoAdd.PersonelUnvani,
                    BirimId = personelDtoAdd.BirimId,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };
                _personelDal.Add(personel);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Personel ekleme alanları gerektiği gibi doldurulmamış. Lütfen istenilen bilgileri eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IDataResult<Personel> GetById(long id)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(x => x.Id == id));
        }

        public IDataResult<PersonelDtoSelect> GetPersonelDetailsById(long id)
        {
            return new SuccessDataResult<PersonelDtoSelect>(_personelDal.GetPersonel(x => x.Id == id));
        }

        public IDataResult<List<PersonelDtoSelect>> GetPersonelDetailsNotDeleted()
        {
            return new SuccessDataResult<List<PersonelDtoSelect>>(_personelDal.GetPersonelDetails(x => x.UserDeleted == false));
        }

        public IDataResult<List<Personel>> NotDeleted()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long id)
        {
            try
            {
                var oldEntity = _personelDal.Get(x => x.Id == id);
                var personel = new Personel
                {
                    Id = id,
                    PersonelAdi = oldEntity.PersonelAdi,
                    PersonelSoyadi = oldEntity.PersonelSoyadi,
                    PersonelSicili = oldEntity.PersonelSicili,
                    PersonelUnvani = oldEntity.PersonelUnvani,
                    BirimId = oldEntity.BirimId,
                    UserDeleted = true,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                };
                _personelDal.Update(personel);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult("İlgili personel silinirken bir hata meydana geldi. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
