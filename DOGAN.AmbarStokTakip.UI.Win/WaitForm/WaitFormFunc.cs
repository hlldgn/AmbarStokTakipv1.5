using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOGAN.AmbarStokTakip.UI.Win.WaitForm
{
    public class WaitFormFunc
    {
        frmWait frmWait;
        Thread thread;
        public void Show()
        {
            thread = new Thread(new ThreadStart(LoadingProcess));
            thread.Start();
        }
        public void Show(Form parent)
        {
            thread=new Thread(new ParameterizedThreadStart(LoadingProcess));
            thread.Start(parent);
        }
        public void Close()
        {
            if(frmWait!=null)
            {
                frmWait.BeginInvoke(new System.Threading.ThreadStart(frmWait.CloseWaitForm));
                frmWait = null;
                thread = null;
            }
        }
        public void LoadingProcess()
        {
            frmWait = new frmWait();
            frmWait.ShowDialog();
        }
        private void LoadingProcess(object parent)
        {
            Form parent1=parent as Form;
            frmWait = new frmWait(parent1);
            frmWait.ShowDialog();
        }
    }
}
