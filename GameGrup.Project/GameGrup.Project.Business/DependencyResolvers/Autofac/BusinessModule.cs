using Autofac;
using GameGrup.Project.Business.Abstract;
using GameGrup.Project.Business.Concrete;
using GameGrup.Project.DataAccess.Abstract;
using GameGrup.Project.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGrup.Project.Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
