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
    public class CikisSarfManager : ICikisSarfService
    {
        private ICikisSarfDal _cikisSarfDal;
        public CikisSarfManager(ICikisSarfDal cikisSarfDal)
        {
            _cikisSarfDal = cikisSarfDal;
        }
        public IResult AddOnDto(CikisSarfDtoAdd cikisSarfDtoAdd)
        {            
            var cikisSarf = new CikisSarf
            {
                UrunKayitId = cikisSarfDtoAdd.UrunKayitId,
                Miktar = cikisSarfDtoAdd.Miktar,
                APersonelId = cikisSarfDtoAdd.APersonelId,
                BirimId = cikisSarfDtoAdd.BirimId,
                CikisSarfTarihi = cikisSarfDtoAdd.CikisSarfTarihi,
                UserDeleted = false,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };
            _cikisSarfDal.Add(cikisSarf);
            return new SuccessResult();            
        }

        public IDataResult<CikisSarf> GetById(long id)
        {
            return new SuccessDataResult<CikisSarf>(_cikisSarfDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetailByTarih(DateTime tarih)
        {
            return new SuccessDataResult<List<CikisSarfDtoSelect>>(_cikisSarfDal.GetCikisSarfDetail(x=>x.CikisSarfTarihi==tarih&&x.UserDeleted==false));
        }

        public IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetailByTarih(DateTime tarih, string ara)
        {
            return new SuccessDataResult<List<CikisSarfDtoSelect>>(_cikisSarfDal.GetCikisSarfDetail(x => x.UserDeleted == false && x.CikisSarfTarihi == tarih
            && ((x.APersonel.PersonelAdi + " " + x.APersonel.PersonelSoyadi).ToUpper().Contains(ara)||x.Birim.BirimAdi.ToUpper().Contains(ara))));
        }

        public IDataResult<List<CikisSarfDtoSelect>> GetCikisSarfDetails()
        {
            return new SuccessDataResult<List<CikisSarfDtoSelect>>(_cikisSarfDal.GetCikisSarfDetail(x => x.UserDeleted == false));
        }

        public IDataResult<List<CikisSarf>> NotDeleted()
        {
            return new SuccessDataResult<List<CikisSarf>>(_cikisSarfDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long cikisSarfId)
        {
            try
            {
                var oldEntity = _cikisSarfDal.Get(x => x.Id == cikisSarfId);
                var cikisSarf = new CikisSarf
                {
                    Id = cikisSarfId,
                    APersonelId = oldEntity.APersonelId,
                    BirimId = oldEntity.BirimId,
                    CikisSarfTarihi = oldEntity.CikisSarfTarihi,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                    Miktar = oldEntity.Miktar,
                    UrunKayitId = oldEntity.UrunKayitId,
                    UserDeleted = true,
                };
                _cikisSarfDal.Update(cikisSarf);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
               return new ErrorResult(ex.Message);
            }
        }
    }
}
