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
    public class AlimUrunManager : IAlimUrunService
    {
        IAlimUrunDal _alimUrunDal;
        public AlimUrunManager(IAlimUrunDal alimUrunDal)
        {
            _alimUrunDal = alimUrunDal;
        }

        public IResult AddonDto(AlimUrunDtoAdd alimUrunDtoAdd)
        {
            var alimUrun = new AlimUrun
            {
                ProgramDeleted = false,
                UserDeleted = false,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                UrunId = alimUrunDtoAdd.UrunId,
                AlimId = alimUrunDtoAdd.AlimId,
                BirimFiyat = alimUrunDtoAdd.BirimFiyat,
                BirimFiyatKDVHaric=alimUrunDtoAdd.BirimFiyatKDVHaric,
                Kdv=alimUrunDtoAdd.Kdv,
                Miktar = alimUrunDtoAdd.Miktar,
                MiktarKalan = alimUrunDtoAdd.MiktarKalan,
                TedarikciFirma = alimUrunDtoAdd.TedarikciFirma,
                ToplamTutar = alimUrunDtoAdd.ToplamTutar,
            };
            _alimUrunDal.Add(alimUrun);
            return new SuccessResult();
        }

        public IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetails(long id)
        {
            return new SuccessDataResult<List<AlimUrunDtoSelect>>(_alimUrunDal.GetAlimUrunDetails(x => x.AlimId == id));
        }

        public IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetailsByIdNotDeleted(long id)
        {
            return new SuccessDataResult<List<AlimUrunDtoSelect>>(_alimUrunDal.GetAlimUrunDetails(x => x.ProgramDeleted == false && x.UserDeleted == false && x.AlimId == id));
        }

        public IDataResult<List<AlimUrunDtoSelect>> GetAlimUrunDetailsByTedarikciFirma()
        {
            return new SuccessDataResult<List<AlimUrunDtoSelect>>(_alimUrunDal.GetAlimUrunDetails(x => x.UserDeleted == false));
        }

        public IDataResult<AlimUrunMuayeneKabulDtoSelect> GetAlimUrunMuayeneKabul(long id)
        {
            return new SuccessDataResult<AlimUrunMuayeneKabulDtoSelect>(_alimUrunDal.GetAlimUrun(x => x.Id == id));
        }

        public IDataResult<AlimUrun> GetById(long id)
        {
            return new SuccessDataResult<AlimUrun>(_alimUrunDal.Get(x => x.Id == id));
        }

        public decimal GetSumAlimUrunAlinanMiktar(long alimId)
        {
            return _alimUrunDal.GetToplamDoubleFilter(x => x.AlimId == alimId, x => x.Miktar);
        }

        public IDataResult<List<AlimUrun>> NotDeleted()
        {
            return new SuccessDataResult<List<AlimUrun>>(_alimUrunDal.GetAll(x => x.ProgramDeleted == false && x.UserDeleted == false));
        }

        public IResult UpdateDeleteForProgram(long id, decimal miktar)
        {
            try
            {
                var oldEntity = _alimUrunDal.Get(x => x.Id == id);
                decimal miktarKalan = oldEntity.MiktarKalan;
                decimal sonuc = miktarKalan - miktar;
                var alimUrun = new AlimUrun
                {
                    Id = id,
                    AlimId = oldEntity.AlimId,
                    BirimFiyat = oldEntity.BirimFiyat,
                    BirimFiyatKDVHaric=oldEntity.BirimFiyatKDVHaric,
                    Kdv=oldEntity.Kdv,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = sonuc,
                    TedarikciFirma = oldEntity.TedarikciFirma,
                    UrunId = oldEntity.UrunId,
                    ToplamTutar = oldEntity.ToplamTutar,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                    ProgramDeleted = sonuc <= 0 ? true : false,
                    UserDeleted = false,
                };
                _alimUrunDal.Update(alimUrun);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        public IResult UpdateDeleteForUser(long id, decimal miktar)
        {
            try
            {
                var oldEntity = _alimUrunDal.Get(x => x.Id == id);
                decimal miktarKalan = oldEntity.MiktarKalan;
                decimal sonuc = miktarKalan + miktar;
                var alimUrun = new AlimUrun
                {
                    Id = id,
                    AlimId = oldEntity.AlimId,
                    BirimFiyat = oldEntity.BirimFiyat,
                    BirimFiyatKDVHaric = oldEntity.BirimFiyatKDVHaric,
                    Kdv = oldEntity.Kdv,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = sonuc,
                    TedarikciFirma = oldEntity.TedarikciFirma,
                    UrunId = oldEntity.UrunId,
                    ToplamTutar = oldEntity.ToplamTutar,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                    ProgramDeleted = false,
                    UserDeleted = false,
                };
                _alimUrunDal.Update(alimUrun);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        decimal IAlimUrunService.GetSumAlimUrunMiktarKalan(long alimId)
        {
            return _alimUrunDal.GetToplamDoubleFilter(x => x.AlimId == alimId, x => x.MiktarKalan);
        }
    }
}
