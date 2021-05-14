using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Security.Jwt;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Utilities.Interceptors.MethodInterception;

namespace Business.Dependency_Resolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TopicManager >().As<ITopicService>().SingleInstance();
            builder.RegisterType< EfTopicDal > ().As<ITopicDal>().SingleInstance();


            builder.RegisterType< UserPhotoManager > ().As<IUserPhotoService>().SingleInstance();
            builder.RegisterType< EfPhotoDal > ().As<IUserPhotoDal>().SingleInstance();


            builder.RegisterType< UserManager > ().As<IUserService> ();
            builder.RegisterType< EfUserDal > ().As<IUserDal>();

            builder.RegisterType< CommentManager > ().As<ICommentService> ().SingleInstance();
            builder.RegisterType< EfCommentDal > ().As<ICommentDal> ().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
