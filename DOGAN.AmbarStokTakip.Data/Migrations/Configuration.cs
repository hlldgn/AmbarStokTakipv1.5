using DOGAN.AmbarStokTakip.Data.Context;
using System.Data.Entity.Migrations;

namespace DOGAN.AmbarStokTakip.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AmbarStokTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }
    }
}
