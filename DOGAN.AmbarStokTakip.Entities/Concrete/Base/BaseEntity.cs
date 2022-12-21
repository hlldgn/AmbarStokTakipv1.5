using DOGAN.AmbarStokTakip.Core.Entities;
using System;

namespace DOGAN.AmbarStokTakip.Entities.Concrete.Base
{
    public class BaseEntity:IEntity
    {
        public long Id { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
