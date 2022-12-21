using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Core.Utilities.Result;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoCommand;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            _faturaDal = faturaDal;
        }

        public IResult AddonDto(FaturaDtoAdd faturaDtoAdd)
        {
            var fatura = new Fatura
            {
                FaturaTarihi = faturaDtoAdd.FaturaTarihi,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                UserDeleted = false,
                UrunKayitId = faturaDtoAdd.UrunKayitId,
            };
            _faturaDal.Add(fatura);
            return new SuccessResult();

        }

        public IDataResult<Fatura> GetById(long id)
        {
            return new SuccessDataResult<Fatura>(_faturaDal.Get(x => x.Id == id));
        }

        public IDataResult<List<FaturaDtoSelect>> GetFaturaNotDeletedDetails()
        {
            return new SuccessDataResult<List<FaturaDtoSelect>>(_faturaDal.GetorSearchFaturaDetails(x => x.UserDeleted == false));
        }

        public IDataResult<Fatura> GetFaturaUrunKayitId(long urunKayitId)
        {
            return new SuccessDataResult<Fatura>(_faturaDal.Get(x => x.UrunKayitId == urunKayitId));
        }

        public IDataResult<List<Fatura>> NotDeleted()
        {
            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(x => x.UserDeleted == false));
        }

        public IDataResult<List<FaturaDtoSelect>> SearchFaturaNotDeletedDetails(DateTime tarih)
        {
            return new SuccessDataResult<List<FaturaDtoSelect>>(_faturaDal.GetorSearchFaturaDetails(x => x.UserDeleted == false, x => x.FaturaTarihi == tarih));
        }

        public IResult UpdateForUser(long Id)
        {
            try
            {
                var oldEntity = _faturaDal.Get(x => x.Id == Id);
                var fatura = new Fatura
                {
                    Id = Id,
                    CreateDate = oldEntity.CreateDate,
                    FaturaTarihi = oldEntity.FaturaTarihi,
                    UpdateDate = DateTime.Now,
                    UrunKayitId = oldEntity.UrunKayitId,
                    UserDeleted = true,
                };
                _faturaDal.Update(fatura);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult();
            }
        }
    }
}
