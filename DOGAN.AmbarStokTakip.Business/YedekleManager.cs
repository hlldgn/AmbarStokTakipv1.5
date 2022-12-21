using DOGAN.AmbarStokTakip.DataaccessLayer;

namespace DOGAN.AmbarStokTakip.Business
{
    public class YedekleManager
    {
        public void Yedekle(string path)
        { 
            YedekleDal yedekleDal = new YedekleDal();
            yedekleDal.yedekle(path);
        }
        public void yedektenAl(string path)
        {
            YedekleDal yedekleDal = new YedekleDal();
            yedekleDal.yedektenAl(path);
        }
    }
}
