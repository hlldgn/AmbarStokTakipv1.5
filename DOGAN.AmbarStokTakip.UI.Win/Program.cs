using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DOGAN.AmbarStokTakip.UI.Win
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(false, "SINGLE_INSTANCE_APP_MUTEX");
            if (!mutex.WaitOne(0, false))
            {
                mutex.Close();
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MdiFormsOn());
            }
        }
    }
}
