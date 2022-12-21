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
    public class TelefonRehberManager : ITelefonRehberService
    {
        private readonly ITelefonRehberDal _telefonRehberDal;
        public TelefonRehberManager(ITelefonRehberDal telefonRehberDal)
        {
            _telefonRehberDal = telefonRehberDal;
        }

        public IResult AddOnDto(TelefonRehberDtoAdd telefonRehberDtoAdd)
        {
            if(telefonRehberDtoAdd.IsletmeAdi!=string.Empty)
            {
                var rehber = new TelefonRehber
                {
                    EPosta = telefonRehberDtoAdd.EPosta,
                    IsletmeAdi = telefonRehberDtoAdd.IsletmeAdi,
                    Adres = telefonRehberDtoAdd.Adres,
                    Fax = telefonRehberDtoAdd.Fax,
                    IlgiliKisiAdSoyad = telefonRehberDtoAdd.IlgiliKisiAdSoyad,
                    TelefonNo = telefonRehberDtoAdd.TelefonNo,
                    TelefonNo2=telefonRehberDtoAdd.TelefonNo2,
                    VergiTCNo = telefonRehberDtoAdd.VergiTCNo,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    UserDeleted = false,
                };
                _telefonRehberDal.Add(rehber);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Lütfen istenilen alanları eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IDataResult<TelefonRehber> GetById(long id)
        {
            return new SuccessDataResult<TelefonRehber>(_telefonRehberDal.Get(x => x.Id == id));
        }

        public IDataResult<List<TelefonRehberDtoSelect>> GetTelefonRehberNotDeleted()
        {
            return new SuccessDataResult<List<TelefonRehberDtoSelect>>(_telefonRehberDal.GetorSearchTelefonRehberDetails(x => x.UserDeleted == false));
        }

        public IDataResult<List<TelefonRehber>> NotDeleted()
        {
            return new SuccessDataResult<List<TelefonRehber>>(_telefonRehberDal.GetAll(x => x.UserDeleted == false));
        }

        public IDataResult<List<TelefonRehberDtoSelect>> SearchTelefonRehberNotDeleted(string ara)
        {
            return new SuccessDataResult<List<TelefonRehberDtoSelect>>(_telefonRehberDal.GetorSearchTelefonRehberDetails(x => x.UserDeleted == false,
                x => x.IsletmeAdi.Contains(ara) || x.IlgiliKisiAdSoyad.Contains(ara) || x.TelefonNo.Contains(ara)||x.TelefonNo2.Contains(ara)));
        }

        public IResult UpdateDeleteForUser(long Id)
        {
            var oldEntity = _telefonRehberDal.Get(x => x.Id == Id);
            var rehber = new TelefonRehber
            {
                Id = Id,
                Adres = oldEntity.Adres,
                EPosta = oldEntity.EPosta,
                Fax = oldEntity.Fax,
                IlgiliKisiAdSoyad = oldEntity.IlgiliKisiAdSoyad,
                IsletmeAdi = oldEntity.IsletmeAdi,
                TelefonNo = oldEntity.TelefonNo,
                TelefonNo2=oldEntity.TelefonNo2,
                VergiTCNo = oldEntity.VergiTCNo,
                CreateDate = oldEntity.CreateDate,
                UpdateDate = DateTime.Now,
                UserDeleted = true,
            };
            _telefonRehberDal.Update(rehber);
            return new SuccessResult();
        }

        public IResult UpdateForUser(TelefonRehberDtoSelect telefonRehberDtoSelect)
        {
            var oldEntity = _telefonRehberDal.Get(x => x.Id == telefonRehberDtoSelect.Id);
            var rehber = new TelefonRehber
            {
                Id = telefonRehberDtoSelect.Id,
                Adres = telefonRehberDtoSelect.Adres,
                EPosta = telefonRehberDtoSelect.EPosta,
                Fax = telefonRehberDtoSelect.Fax,
                IlgiliKisiAdSoyad = telefonRehberDtoSelect.IlgiliKisiAdSoyad,
                IsletmeAdi = telefonRehberDtoSelect.IsletmeAdi,
                TelefonNo = telefonRehberDtoSelect.TelefonNo,
                TelefonNo2 = telefonRehberDtoSelect.TelefonNo2,
                VergiTCNo = telefonRehberDtoSelect.VergiTCNo,
                CreateDate = oldEntity.CreateDate,
                UpdateDate = DateTime.Now,
                UserDeleted = false,
            };
            _telefonRehberDal.Update(rehber);
            return new SuccessResult();
        }
    }
}
