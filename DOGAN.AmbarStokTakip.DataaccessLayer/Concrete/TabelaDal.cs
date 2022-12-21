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
    public class TabelaDal : EntityRepositoryBase<Tabela, AmbarStokTakipContext>, ITabelaDal
    {
        public int AyniTarihTabelaKayitKontrol(DateTime tabelaTarih)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Tabela>().Where(x =>  x.UserDeleted == false && x.TabelaTarihi == tabelaTarih).Count();
            }
        }

        public List<TabelaDtoSelect> GetTabelaDetails(Expression<Func<Tabela, bool>> filter)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                return context.Set<Tabela>().Where(filter).Select(x => new TabelaDtoSelect
                {
                    Id = x.Id,
                    Sabah = x.Sabah,
                    Ogle = x.Ogle,
                    Aksam = x.Aksam,
                    TabelaTarihi = x.TabelaTarihi
                }).OrderByDescending(x=>x.TabelaTarihi).ToList();
            }
        }
    }
}
