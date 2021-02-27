using GameGrup.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGrup.Project.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
    }
}
