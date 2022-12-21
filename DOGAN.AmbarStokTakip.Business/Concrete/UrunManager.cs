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
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public IResult AddonDto(UrunDtoAdd urunDtoAdd)
        {
            if (urunDtoAdd.Birim != String.Empty && urunDtoAdd.UrunAdi != String.Empty)
            {
                int result = _urunDal.EntityCount(x => x.UrunAdi == urunDtoAdd.UrunAdi && x.UserDeleted==false);
                if(result>0)
                {
                    return new ErrorResult("Aynı isimde ürün eklenemez.");
                }
                else
                {
                    var urun = new Urun
                    {
                        Birim = urunDtoAdd.Birim,
                        CreateDate = DateTime.Now,
                        UserDeleted = false,
                        IaseOrSarf = urunDtoAdd.IaseOrSarf,
                        Kalori = urunDtoAdd.Kalori,
                        UpdateDate = DateTime.Now,
                        UrunAdi = urunDtoAdd.UrunAdi,
                    };
                    _urunDal.Add(urun);
                    return new SuccessResult();
                }
            }
            else
            {
                return new ErrorResult("Ürün Ekleme Alanları gerektiği gibi doldurulmamış. Lütfen eksiksiz doldurup tekrar deneyiniz.");
            }
        }
        public IDataResult<Urun> GetById(long id)
        {
            return new SuccessDataResult<Urun>(_urunDal.Get(x => x.Id == id));
        }

        public IDataResult<List<UrunDtoSelect>> GetUrunDetailUrunAdiBirimNotDeleted()
        {
            return new SuccessDataResult<List<UrunDtoSelect>>(_urunDal.GetUrunDetailsUrunAdiBirim(x => x.UserDeleted == false&&x.IaseOrSarf==false));
        }

        public IDataResult<List<UrunDtoSelect>> GetUrunDetailUrunAdiBirimNotDeleted(string contains)
        {
            return new SuccessDataResult<List<UrunDtoSelect>>(_urunDal.GetUrunDetailsUrunAdiBirim(x => x.UserDeleted == false && x.IaseOrSarf == false,x=>x.UrunAdi.Contains(contains)));
        }

        public IDataResult<List<UrunDtoSelectWitKalori>> GetUrunDetailWithKaloriNotDeleted()
        {
            return new SuccessDataResult<List<UrunDtoSelectWitKalori>>(_urunDal.GetUrundetailsUrunAdiBirimKalori(x=>x.UserDeleted==false&&x.IaseOrSarf==true));
        }

        public IDataResult<List<UrunDtoSelectWitKalori>> GetUrunDetailWithKaloriNotDeleted(string contains)
        {
            return new SuccessDataResult<List<UrunDtoSelectWitKalori>>(_urunDal.GetUrundetailsUrunAdiBirimKalori(x => x.UserDeleted == false && x.IaseOrSarf == true, x => x.UrunAdi.Contains(contains)));
        }

        public IDataResult<List<Urun>> NotDeleted()
        {
            return new SuccessDataResult<List<Urun>>(_urunDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long Id)
        {
            try
            {
                var oldEntity = _urunDal.Get(x => x.Id == Id);
                var urun = new Urun
                {
                    Id = Id,
                    Birim = oldEntity.Birim,
                    CreateDate = oldEntity.CreateDate,
                    IaseOrSarf = oldEntity.IaseOrSarf,
                    Kalori = oldEntity.Kalori,
                    UrunAdi = oldEntity.UrunAdi,
                    UserDeleted = true,
                    UpdateDate=DateTime.Now
                };
                _urunDal.Update(urun);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
