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
    public class PersonelDal : EntityRepositoryBase<Personel, AmbarStokTakipContext>, IPersonelDal
    {
        public PersonelDtoSelect GetPersonel(Expression<Func<Personel, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Personel>().Where(filter).Select(x => new PersonelDtoSelect
                {
                    Id = x.Id,
                    PersonelAdi = x.PersonelAdi,
                    PersonelSoyadi = x.PersonelSoyadi,
                    PersonelUnvani = x.PersonelUnvani,
                    PersonelSicili = x.PersonelSicili,
                    BirimAdi = x.Birim.BirimAdi,
                    PersonelAdPersonelSoyad = x.PersonelAdi + " " + x.PersonelSoyadi,
                }).FirstOrDefault();
            }
        }

        public List<PersonelDtoSelect> GetPersonelDetails(Expression<Func<Personel, bool>> filter)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                return context.Set<Personel>().Where(filter).Select(x => new PersonelDtoSelect
                {
                    Id = x.Id,
                    PersonelAdi = x.PersonelAdi,
                    PersonelSoyadi = x.PersonelSoyadi,
                    PersonelUnvani = x.PersonelUnvani,
                    PersonelSicili = x.PersonelSicili,
                    BirimAdi = x.Birim.BirimAdi,
                    PersonelAdPersonelSoyad=x.PersonelAdi+" "+x.PersonelSoyadi,
                }).OrderBy(x=>x.PersonelAdi).ToList();
            }
        }
    }
}
