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
    public class YemekManager : IYemekService
    {
        IYemekDal _yemekDal;
        public YemekManager(IYemekDal yemekDal)
        {
            _yemekDal= yemekDal;
        }
        public IResult AddonDto(YemekDtoAdd yemekDtoAdd)
        {
            if(yemekDtoAdd.YemekAdi!=String.Empty)
            {
                int kayitKontrol = _yemekDal.GetAll(x => x.YemekAdi == yemekDtoAdd.YemekAdi).Count;
                if(kayitKontrol<=0)
                {
                    var yemek = new Yemek
                    {
                        YemekAdi = yemekDtoAdd.YemekAdi,
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        UserDeleted = false,
                    };
                    _yemekDal.Add(yemek);
                    return new SuccessResult();
                }
                else
                {
                    return new ErrorResult();
                }
            }
            else
            {
                return new ErrorResult();
            }
        }

        public IDataResult<Yemek> GetById(long id)
        {
            return new SuccessDataResult<Yemek>(_yemekDal.Get(x => x.Id == id));
        }

        public IDataResult<List<YemekDtoSelect>> GetYemekDetails()
        {
            return new SuccessDataResult<List<YemekDtoSelect>>(_yemekDal.GetYemekDetails());
        }

        public IDataResult<List<Yemek>> NotDeleted()
        {
            return new SuccessDataResult<List<Yemek>>(_yemekDal.GetAll(x => x.UserDeleted == false));
        }
    }
}
