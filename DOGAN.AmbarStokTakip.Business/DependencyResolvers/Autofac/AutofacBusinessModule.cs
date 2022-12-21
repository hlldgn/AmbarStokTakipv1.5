using Autofac;
using DOGAN.AmbarStokTakip.Business.Abstract;
using DOGAN.AmbarStokTakip.Business.Concrete;
using DOGAN.AmbarStokTakip.DataaccessLayer.Abstract;
using DOGAN.AmbarStokTakip.DataaccessLayer.Concrete;

namespace DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AlimManager>().As<IAlimService>().SingleInstance();
            builder.RegisterType<AlimDal>().As<IAlimDal>().SingleInstance();

            builder.RegisterType<AlimUrunManager>().As<IAlimUrunService>().SingleInstance();
            builder.RegisterType<AlimUrunDal>().As<IAlimUrunDal>().SingleInstance();

            builder.RegisterType<DepoManager>().As<IDepoService>().SingleInstance();
            builder.RegisterType<DepoDal>().As<IDepoDal>().SingleInstance();

            builder.RegisterType<UrunManager>().As<IUrunService>().SingleInstance();
            builder.RegisterType<UrunDal>().As<IUrunDal>().SingleInstance();

            builder.RegisterType<BirimManager>().As<IBirimService>().SingleInstance();
            builder.RegisterType<BirimDal>().As<IBirimDal>().SingleInstance();

            builder.RegisterType<TabelaManager>().As<ITabelaService>().SingleInstance();
            builder.RegisterType<TabelaDal>().As<ITabelaDal>().SingleInstance();

            builder.RegisterType<PersonelManager>().As<IPersonelService>().SingleInstance();
            builder.RegisterType<PersonelDal>().As<IPersonelDal>().SingleInstance();

            builder.RegisterType<UrunKayitManager>().As<IUrunKayitService>().SingleInstance();
            builder.RegisterType<UrunKayitDal>().As<IUrunKayitDal>().SingleInstance();

            builder.RegisterType<YemekManager>().As<IYemekService>().SingleInstance();
            builder.RegisterType<YemekDal>().As<IYemekDal>().SingleInstance();

            builder.RegisterType<FaturaManager>().As<IFaturaService>().SingleInstance();
            builder.RegisterType<FaturaDal>().As<IFaturaDal>().SingleInstance();

            builder.RegisterType<OdemeManager>().As<IOdemeService>().SingleInstance();
            builder.RegisterType<OdemeDal>().As<IOdemeDal>().SingleInstance();

            builder.RegisterType<OtomatikCikisManager>().As<IOtomatikCikisService>().SingleInstance();
            builder.RegisterType<OtomatikCikisDal>().As<IOtomatikCikisDal>().SingleInstance();

            builder.RegisterType<CikisIaseManager>().As<ICikisIaseService>().SingleInstance();
            builder.RegisterType<CikisIaseDal>().As<ICikisIaseDal>().SingleInstance();

            builder.RegisterType<CikisIaseTabelaManager>().As<ICikisIaseTabelaService>().SingleInstance();
            builder.RegisterType<CikisIaseTabelaDal>().As<ICikisIaseTabelaDal>().SingleInstance();

            builder.RegisterType<CikisSarfManager>().As<ICikisSarfService>().SingleInstance();
            builder.RegisterType<CikisSarfDal>().As<ICikisSarfDal>().SingleInstance();

            builder.RegisterType<TelefonRehberManager>().As<ITelefonRehberService>().SingleInstance();
            builder.RegisterType<TelefonRehberDal>().As<ITelefonRehberDal>().SingleInstance();
        }
    }
}
