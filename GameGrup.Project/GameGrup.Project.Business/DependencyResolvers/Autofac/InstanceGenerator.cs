using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGrup.Project.Business.DependencyResolvers.Autofac
{
    public  class InstanceGenerator
    {
        public static T SetInstance<T>()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule<BusinessModule>();

            return containerBuilder.Build().Resolve<T>();
        }
    }
}
