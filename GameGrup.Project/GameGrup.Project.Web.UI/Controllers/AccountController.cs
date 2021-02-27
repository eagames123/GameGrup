using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGrup.Project.Web.UI.Controllers
{
    public class AccountController : Controller
    {        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            return View();
        }

        public IActionResult RememberPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RememberPassword(string email)
        {
            return View();
        }
    }
}
