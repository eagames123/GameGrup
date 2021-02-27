using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGrup.Project.Web.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(string categoryName)
        {
            return View();
        }

        public IActionResult Detail(string productName)
        {
            return View();
        }
    }
}
