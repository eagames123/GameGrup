using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGrup.Project.Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Product : ControllerBase
    {
        [HttpGet]
        public List<object> GetProducts()
        {
            return null;            
        }

        [HttpGet]
        public object GetProduct(int id)
        {
            return null;
        }

        [HttpPost]
        public object PostProduct()
        {
            return null;
        }

        [HttpPut]
        public object PutProduct()
        {
            return null;
        }

        [HttpDelete]
        public object DeleteProduct()
        {
            return null;
        }
    }
}
