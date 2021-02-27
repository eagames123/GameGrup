using GameGrup.Core.DataAccess.EntityFramework;
using GameGrup.Project.DataAccess.Abstract;
using GameGrup.Project.DataAccess.Concrete.Entityframework;
using GameGrup.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGrup.Project.DataAccess.Concrete
{
    public  class EfCategoryDal : EfEntityRepositoryBase<Category, GameGrupContext>, ICategoryDal
    {
    }
}
