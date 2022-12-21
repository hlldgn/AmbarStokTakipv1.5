using DOGAN.AmbarStokTakip.Data.Context;
using System;
using System.Data.Entity;

namespace DOGAN.AmbarStokTakip.DataaccessLayer
{
    public class YedekleDal
    {
        public void yedekle(string path)
        {
            using (AmbarStokTakipContext context = new AmbarStokTakipContext())
            {
                string connectionString = context.Database.Connection.Database.ToString();
                string cmd = "BACKUP DATABASE [" + connectionString + "] TO DISK ='"+path+"\\"+DateTime.Now.ToShortDateString()+"AmbarStokTakip"+".bak'";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
            }
        }
        public void yedektenAl(string path)
        {
            using (AmbarStokTakipContext context=new AmbarStokTakipContext())
            {
                string connectionString = context.Database.Connection.Database.ToString();
                string cmd = string.Format("ALTER DATABASE [" + connectionString + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd);
                string cmd1 = "USE MASTER RESTORE DATABASE [" + connectionString + "] FROM DISK='" + path + "' WITH REPLACE;";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd1);
                string cmd2 = string.Format("ALTER DATABASE [" + connectionString + "] SET MULTI_USER");
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd2);
            }
        }
    }
}
