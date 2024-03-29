﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Bussines.Abstract;
using Bussines.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFrameWork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.DependencyResolvers.Autofac
{
     public class AutofacBusinessModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<CategoryManager>().As<ICategoryServices>().SingleInstance();
                builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

                builder.RegisterType<ProductManager>().As<IProductServices>().SingleInstance();
                builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();


                builder.RegisterType<UserManager>().As<IUserService>();
                builder.RegisterType<EfUserDal>().As<IUserDal>();
                
                builder.RegisterType<AuthManager>().As<IAuthService>();
                builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
    
}
