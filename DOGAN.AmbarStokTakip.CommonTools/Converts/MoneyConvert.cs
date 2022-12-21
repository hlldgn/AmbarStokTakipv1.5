using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGAN.AmbarStokTakip.CommonTools.Converts
{
    public static class MoneyConvert
    {
        public static string ConvertMoneyFormat(double money)
        {
            string formattedMoney = string.Format("{0:C5}", money);
            return formattedMoney;
        }
    }
}
