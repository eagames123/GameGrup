using GameGrup.Project.Business.Abstract;
using GameGrup.Project.Business.Concrete;
using GameGrup.Project.Business.DependencyResolvers.Autofac;
using GameGrup.Project.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GameGrup.Project.Business.Test
{

    public class CategoryTest
    {
        [Fact]
        public void GetList()
        {
            ICategoryService categoryListCount = InstanceGenerator.SetInstance<ICategoryService>();

            int sonuc = categoryListCount.GetList().Count;

            Assert.Equal(5, sonuc);
        }
    }
}
