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
    public class OtomatikCikisManager : IOtomatikCikisService
    {
        IOtomatikCikisDal _otomatikCikisDal;
        public OtomatikCikisManager(IOtomatikCikisDal otomatikCikisDal)
        {
            _otomatikCikisDal = otomatikCikisDal;
        }
        public IResult AddonDTo(OtomatikCikisDtoAdd otomatikCikisDtoAdd)
        {
            if (otomatikCikisDtoAdd.sabahCikis.ToString() != String.Empty
                && otomatikCikisDtoAdd.ogleCikis.ToString() != String.Empty
                && otomatikCikisDtoAdd.aksamCikis.ToString() != String.Empty)
            {
                var otomatikCikis = new OtomatikCikis
                {
                    sabahCikis = otomatikCikisDtoAdd.sabahCikis,
                    ogleCikis = otomatikCikisDtoAdd.ogleCikis,
                    aksamCikis = otomatikCikisDtoAdd.aksamCikis,
                    secim = otomatikCikisDtoAdd.secim,
                    UrunId = otomatikCikisDtoAdd.UrunId,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    UserDeleted = false,
                };
                _otomatikCikisDal.Add(otomatikCikis);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult("Öğünlerde çıkılacak miktarları eksiksiz doldurup tekrar deneyiniz.");
            }
        }

        public IResult GetAyniIsimliUrunKaydiKontrol(long urunId)
        {
            var result = _otomatikCikisDal.EntityCount(x => x.UrunId == urunId&&x.UserDeleted==false);
            if (result > 0)
            {
                return new ErrorResult("Bu ürün ile ilgili otomatik cıkış kaydı mevcuttur. Lütfen başka bir ürün seçiniz veya ilgili ürünün kaydını silip yeni bir kayıt ekleyiniz.");
            }
            else
            {
                return new SuccessResult();
            }
        }

        public IDataResult<OtomatikCikis> GetById(long id)
        {
            return new SuccessDataResult<OtomatikCikis>(_otomatikCikisDal.Get(x => x.Id == id));
        }

        public IDataResult<OtomatikCikis> GetByOtomatikCikisDetailsUrunIdSecimiBanaBirak(long urunId)
        {
            return new SuccessDataResult<OtomatikCikis>(_otomatikCikisDal.Get(x => x.UrunId == urunId&&x.secim==false&&x.UserDeleted==false));
        }

        public IDataResult<List<OtomatikCikis>> GetOtomatikCikisDetailNotDeletedAndHerIase()
        {
            return new SuccessDataResult<List<OtomatikCikis>>(_otomatikCikisDal.GetAll(x => x.UserDeleted == false && x.secim == true));
        }

        public IDataResult<List<OtomatikCikisDtoSelect>> GetSelectOtomatikCikisDetailsNotDeleted()
        {
            return new SuccessDataResult<List<OtomatikCikisDtoSelect>>(_otomatikCikisDal.GetOtomatikCikisDetails(x => x.UserDeleted == false));
        }

        public IDataResult<List<OtomatikCikis>> NotDeleted()
        {
            return new SuccessDataResult<List<OtomatikCikis>>(_otomatikCikisDal.GetAll(x => x.UserDeleted == false));
        }

        public IResult UpdateDeleteForUser(long id)
        {
            try
            {
                var oldEntity = _otomatikCikisDal.Get(x => x.Id == id);
                var otomatikCikis = new OtomatikCikis
                {
                    Id = id,
                    sabahCikis = oldEntity.sabahCikis,
                    ogleCikis = oldEntity.ogleCikis,
                    aksamCikis = oldEntity.aksamCikis,
                    CreateDate = oldEntity.CreateDate,
                    secim = oldEntity.secim,
                    UpdateDate = oldEntity.UpdateDate,
                    UrunId = oldEntity.UrunId,
                    UserDeleted = true,
                };
                _otomatikCikisDal.Update(otomatikCikis);
                return new SuccessResult();
            }
            catch
            {
                return new ErrorResult("İlgili ürüne ait otomatik çıkış bilgisi silinirken bir hata oluştu. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
