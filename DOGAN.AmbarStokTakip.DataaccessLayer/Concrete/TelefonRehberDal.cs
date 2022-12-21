using DOGAN.AmbarStokTakip.Core.DataAccessLayer.EntityFramework;
using DOGAN.AmbarStokTakip.Data.Context;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.Entities.Concrete;
using DOGAN.AmbarStokTakip.Entities.Concrete.Dto.DtoQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DOGAN.AmbarStokTakip.DataaccessLayer.Concrete
{
    public class TelefonRehberDal : EntityRepositoryBase<TelefonRehber, AmbarStokTakipContext>, ITelefonRehberDal
    {
        public List<TelefonRehberDtoSelect> GetorSearchTelefonRehberDetails(Expression<Func<TelefonRehber, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<TelefonRehber>().Where(filter).Select(x => new TelefonRehberDtoSelect
                {
                    Id = x.Id,
                    IlgiliKisiAdSoyad = x.IlgiliKisiAdSoyad,
                    Adres = x.Adres,
                    EPosta = x.EPosta,
                    Fax = x.Fax,
                    IsletmeAdi = x.IsletmeAdi,
                    TelefonNo = x.TelefonNo,
                    TelefonNo2=x.TelefonNo2,
                    VergiTCNo = x.VergiTCNo,
                }).ToList();
            }
        }

        public List<TelefonRehberDtoSelect> GetorSearchTelefonRehberDetails(Expression<Func<TelefonRehber, bool>> filter, Expression<Func<TelefonRehber, bool>> contains)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<TelefonRehber>().Where(contains).Where(filter).Select(x => new TelefonRehberDtoSelect
                {
                    Id = x.Id,
                    IlgiliKisiAdSoyad = x.IlgiliKisiAdSoyad,
                    Adres = x.Adres,
                    EPosta = x.EPosta,
                    Fax = x.Fax,
                    IsletmeAdi = x.IsletmeAdi,
                    TelefonNo = x.TelefonNo,
                    TelefonNo2= x.TelefonNo2,
                    VergiTCNo = x.VergiTCNo,
                }).ToList();
            }
        }
    }
}
