using GameGrup.Project.Business.Abstract;
using GameGrup.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGrup.Project.Web.UI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult List(string categoryName)
        {
            List<Category> List = _categoryService.GetList();

            return View();
        }

        public IActionResult Detail(string categoryName)
        {
            return View();
        }
    }
}
