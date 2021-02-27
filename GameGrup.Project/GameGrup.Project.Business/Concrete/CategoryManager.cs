using GameGrup.Project.Business.Abstract;
using GameGrup.Project.DataAccess.Abstract;
using GameGrup.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameGrup.Project.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            List<Category> data = _categoryDal.GetList();

            return data;
        }
    }
}
