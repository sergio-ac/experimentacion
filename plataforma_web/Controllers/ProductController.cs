




using System.Collections.Generic;
using System.Linq;
using ArathsBaby.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace plataforma_web.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
        
            
        }
        [HttpPost]
        public void InsertarProducto(){
            
        }

    }
}