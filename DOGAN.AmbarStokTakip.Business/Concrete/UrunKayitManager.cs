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
    public class UrunKayitManager : IUrunKayitService
    {
        IUrunKayitDal _urunKayitDal;
        public UrunKayitManager(IUrunKayitDal urunKayitDal)
        {
            _urunKayitDal = urunKayitDal;
        }
        public IResult AddonDto(UrunKayitDtoAdd urunKayitDtoAdd)
        {
            var urunKayit = new UrunKayit
            {
                ProgramDeleted = false,
                UserDeleted = false,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                FaturaDurum = false,
                OdemeDurum = false,
                DepoId = urunKayitDtoAdd.DepoId,
                AlimUrunId = urunKayitDtoAdd.AlimUrunId,
                Miktar = urunKayitDtoAdd.Miktar,
                MiktarKalan = urunKayitDtoAdd.MiktarKalan,
                ToplamTutar = urunKayitDtoAdd.ToplamTutar,
                UrunKayitTarihi = urunKayitDtoAdd.UrunKayitTarihi,
            };
            _urunKayitDal.Add(urunKayit);
            return new SuccessResult();
        }

        public IDataResult<UrunKayit> GetById(long id)
        {
            return new SuccessDataResult<UrunKayit>(_urunKayitDal.Get(x => x.Id == id));
        }

        public IDataResult<List<UrunKayitDtoSelect>> GetSelectUrunKayitNotDeletedAndFaturaNotInsert()
        {
            return new SuccessDataResult<List<UrunKayitDtoSelect>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForFaturaAndOdeme(
                x => x.FaturaDurum == false && x.UserDeleted == false));
        }

        public IDataResult<List<UrunKayitDtoSelect>> GetSelectUrunKayitNotDeletedAndOdemeNotInsertAndFaturaInsert()
        {
            return new SuccessDataResult<List<UrunKayitDtoSelect>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForFaturaAndOdeme(
                x => x.FaturaDurum == true && x.OdemeDurum == false && x.UserDeleted == false));
        }

        public IDataResult<UrunKayitDtoSelectForIaseDus> GetUrunKayitDetailsForIaseDus(long urunKayitId)
        {
            return new SuccessDataResult<UrunKayitDtoSelectForIaseDus>(_urunKayitDal.GetByUrunKayitDetailsForIaseDus(urunKayitId));
        }

        public IDataResult<UrunKayitDtoSelectForIase> GetUrunKayitDetailsForOtomatikCikisUrunId(long urunId)
        {
            return new SuccessDataResult<UrunKayitDtoSelectForIase>(_urunKayitDal.GetByUrunKayitDetailsForIase(x => x.ProgramDeleted == false
            && x.ProgramDeleted == false && x.AlimUrun.UrunId == urunId));
        }

        public IDataResult<List<UrunKayitDtoSelectForIase>> GetUrunKayitSelectForIaseNotDeleted(DateTime tarih)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForIase>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForIase(
                x => x.UserDeleted == false && x.ProgramDeleted == false && x.AlimUrun.Urun.IaseOrSarf == true && x.UrunKayitTarihi <= tarih));
        }

        public IResult IlkUrunKayitCıkısKontrol(DateTime urunKayitTarih, string urunAdi)
        {
            int result = _urunKayitDal.EntityCount(x => x.AlimUrun.Urun.UrunAdi == urunAdi && x.UrunKayitTarihi < urunKayitTarih
            &&x.UserDeleted==false&&x.ProgramDeleted==false);
            if (result > 0)
            {
                return new ErrorResult();
            }
            else
            {
                return new SuccessResult();
            }
        }

        public IDataResult<List<UrunKayit>> NotDeleted()
        {
            return new SuccessDataResult<List<UrunKayit>>(_urunKayitDal.GetAll(x => x.ProgramDeleted == false && x.UserDeleted == false));
        }

        public IDataResult<List<UrunKayitDtoSelectForIase>> SearchByUrunKayitDetailsForIaseNotDeleted(string ara, DateTime tarih)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForIase>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForIase(
                x => x.ProgramDeleted == false && x.UserDeleted == false && x.AlimUrun.Urun.IaseOrSarf == true && x.UrunKayitTarihi <= tarih, x => x.AlimUrun.Urun.UrunAdi.Contains(ara)));
        }

        public IDataResult<List<UrunKayitDtoSelect>> SearchByUrunKayitDetailsNotDeletedAndFaturaNotInsert(string ara)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelect>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForFaturaAndOdeme(
                x => x.FaturaDurum == false && x.UserDeleted == false,
                x => x.AlimUrun.TedarikciFirma.Contains(ara) || x.AlimUrun.Alim.AlimAdi.Contains(ara)));
        }

        public IDataResult<List<UrunKayitDtoSelect>> SearchByUrunKayitDetailsNotDeletedAndOdemeNotInsertAndFaturaInsert(string ara)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelect>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForFaturaAndOdeme(
                x => x.FaturaDurum == true && x.OdemeDurum == false && x.UserDeleted == false,
                x => x.AlimUrun.TedarikciFirma.Contains(ara) || x.AlimUrun.Alim.AlimAdi.Contains(ara)));
        }

        public IResult UpdateDeleteForProgram(long Id, bool fatura, bool odeme)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == Id);
                var urunKayit = new UrunKayit
                {
                    Id = Id,
                    AlimUrunId = oldEntity.AlimUrunId,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = oldEntity.MiktarKalan,
                    ProgramDeleted = oldEntity.ProgramDeleted,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = oldEntity.UserDeleted,
                    FaturaDurum = fatura,
                    OdemeDurum = odeme,
                    DepoId = oldEntity.DepoId,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                };
                _urunKayitDal.Update(urunKayit);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult UpdateDeleteForIaseIptal(long Id, decimal kalanMiktar)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == Id);
                var urunKayit = new UrunKayit
                {
                    Id = Id,
                    AlimUrunId = oldEntity.AlimUrunId,
                    CreateDate = oldEntity.CreateDate,
                    FaturaDurum = oldEntity.FaturaDurum,
                    Miktar = oldEntity.Miktar,
                    OdemeDurum = oldEntity.OdemeDurum,
                    ProgramDeleted = false,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UpdateDate = DateTime.Now,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    DepoId = oldEntity.DepoId,
                    UserDeleted = false,
                    MiktarKalan = oldEntity.MiktarKalan + kalanMiktar,
                };
                _urunKayitDal.Update(urunKayit);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult UpdateForIaseOrSarf(long urunKayitId, decimal dusulenMiktar)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == urunKayitId);
                decimal _miktarKalan = oldEntity.MiktarKalan - dusulenMiktar;
                var urunKayit = new UrunKayit
                {
                    Id = urunKayitId,
                    AlimUrunId = oldEntity.AlimUrunId,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = _miktarKalan,
                    ProgramDeleted = _miktarKalan > 0 ? false : true,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = oldEntity.UserDeleted,
                    FaturaDurum = oldEntity.FaturaDurum,
                    OdemeDurum = oldEntity.OdemeDurum,
                    CreateDate = oldEntity.CreateDate,
                    DepoId = oldEntity.DepoId,
                    UpdateDate = DateTime.Now,
                };
                _urunKayitDal.Update(urunKayit);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsNotDeletedForDepoDepoId(long Id)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForDepo>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForDepo(x => x.UserDeleted == false && x.ProgramDeleted == false && x.DepoId == Id));
        }

        public IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsNotDeletedForDepoDepoId(long Id, string contains)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForDepo>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForDepo(x => x.UserDeleted == false && x.ProgramDeleted == false && x.DepoId == Id, x => x.AlimUrun.Urun.UrunAdi.Contains(contains)));
        }

        public IResult UpdateDepoTransfer(long urunKayitId, long hedefDepoId)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == urunKayitId);
                var urunKayitDepo = new UrunKayit
                {
                    Id = urunKayitId,
                    AlimUrunId = oldEntity.AlimUrunId,
                    CreateDate = oldEntity.CreateDate,
                    FaturaDurum = oldEntity.FaturaDurum,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = oldEntity.MiktarKalan,
                    OdemeDurum = oldEntity.OdemeDurum,
                    ProgramDeleted = oldEntity.ProgramDeleted,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UpdateDate = DateTime.Now,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = oldEntity.UserDeleted,
                    DepoId = hedefDepoId,
                };
                _urunKayitDal.Update(urunKayitDepo);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        public IDataResult<List<UrunKayitDtoSelectForDepo>> GetUrunKayitDetailsAll()
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForDepo>>(_urunKayitDal.GetUrunKayitDetailsForDepoAll());
        }

        public IDataResult<List<UrunKayitDtoSelectForSarf>> GetUrunKayitDetalisForSarfNotDeleted(DateTime tarih)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForSarf>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForSarf(x => x.UrunKayitTarihi <= tarih
            && x.UserDeleted == false && x.ProgramDeleted == false && x.AlimUrun.Urun.IaseOrSarf == false));
        }

        public IDataResult<List<UrunKayitDtoSelectForSarf>> SearchUrunKayitDetailsForSarfNotDeleted(string ara, DateTime tarih)
        {
            return new SuccessDataResult<List<UrunKayitDtoSelectForSarf>>(_urunKayitDal.GetOrSearchUrunKayitDetailsForSarf(x => x.AlimUrun.Urun.UrunAdi.Contains(ara),
                x => x.UrunKayitTarihi <= tarih && x.ProgramDeleted == false && x.UserDeleted == false && x.AlimUrun.Urun.IaseOrSarf == false));
        }

        public IResult DeleteForUser(long urunKayitId)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == urunKayitId);
                var urunKayitDepo = new UrunKayit
                {
                    Id = urunKayitId,
                    AlimUrunId = oldEntity.AlimUrunId,
                    CreateDate = oldEntity.CreateDate,
                    FaturaDurum = oldEntity.FaturaDurum,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = oldEntity.MiktarKalan,
                    OdemeDurum = oldEntity.OdemeDurum,
                    ProgramDeleted = oldEntity.ProgramDeleted,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UpdateDate = DateTime.Now,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = true,
                    DepoId = oldEntity.DepoId,
                };
                _urunKayitDal.Update(urunKayitDepo);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }

        public IResult UpdateForFatura(long Id, bool fatura)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == Id);
                var urunKayit = new UrunKayit
                {
                    Id = Id,
                    AlimUrunId = oldEntity.AlimUrunId,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = oldEntity.MiktarKalan,
                    ProgramDeleted = oldEntity.ProgramDeleted,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = oldEntity.UserDeleted,
                    FaturaDurum = fatura,
                    OdemeDurum = oldEntity.OdemeDurum,
                    DepoId = oldEntity.DepoId,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                };
                _urunKayitDal.Update(urunKayit);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult UpdateForOdeme(long Id, bool odeme)
        {
            try
            {
                var oldEntity = _urunKayitDal.Get(x => x.Id == Id);
                var urunKayit = new UrunKayit
                {
                    Id = Id,
                    AlimUrunId = oldEntity.AlimUrunId,
                    Miktar = oldEntity.Miktar,
                    MiktarKalan = oldEntity.MiktarKalan,
                    ProgramDeleted = oldEntity.ProgramDeleted,
                    ToplamTutar = oldEntity.ToplamTutar,
                    UrunKayitTarihi = oldEntity.UrunKayitTarihi,
                    UserDeleted = oldEntity.UserDeleted,
                    FaturaDurum = oldEntity.FaturaDurum,
                    OdemeDurum = odeme,
                    DepoId = oldEntity.DepoId,
                    CreateDate = oldEntity.CreateDate,
                    UpdateDate = DateTime.Now,
                };
                _urunKayitDal.Update(urunKayit);
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
