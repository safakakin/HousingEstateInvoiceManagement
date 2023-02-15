using Autofac;
using Core.Utilities.Message;
using Core.Utilities.Message.Turkish;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Services.Concrete;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Concrete.EntityFramework;
using Autofac.Extras.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Log.Middlewares.Services;
using System.IdentityModel.Tokens.Jwt;
using Core.Utilities.Security.JWT;
using Business.Concrete;
using Business.Abstract;

namespace RezervationSystem.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApartmentManager>().As<IApartmentService>().SingleInstance();
            builder.RegisterType<BlockManager>().As<IBlockService>().SingleInstance();
            builder.RegisterType<CardManager>().As<ICardService>().SingleInstance();
            builder.RegisterType<DebtManager>().As<IDebtService>().SingleInstance();
            builder.RegisterType<MessageManager>().As<IMessageService>().SingleInstance();
            builder.RegisterType<PaymentManager>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<StyleManager>().As<IStyleService>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();

            builder.RegisterType<EfApartmentDal>().As<IApartmentDal>().SingleInstance();
            builder.RegisterType<EfBlockDal>().As<IBlockDal>().SingleInstance();
            builder.RegisterType<EfCardDal>().As<ICardDal>().SingleInstance();
            builder.RegisterType<EfDebtDal>().As<IDebtDal>().SingleInstance();
            builder.RegisterType<EfMessageDal>().As<IMessageDal>().SingleInstance();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>().SingleInstance();
            builder.RegisterType<EfStyleDal>().As<IStyleDal>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<TurkishLanguageMessage>().As<ILanguageMessage>().SingleInstance();
            builder.RegisterType<ConsoleLogger>().As<ILoggerService>().SingleInstance();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                });
        }
    }
}
