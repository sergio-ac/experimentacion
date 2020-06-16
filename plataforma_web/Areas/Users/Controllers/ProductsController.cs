using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using plataforma_web.Areas.Users.Models;

namespace plataforma_web.Areas.Products.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    [Area ("Users")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Products()
        {
            return View();
        }
        [HttpPost]
public IActionResult Productos(FirstTryImage model)
{
   var img = model.MyImage;
   var imgCaption = model.ImageCaption;

   //Getting file meta data
   var fileName = Path.GetFileName(model.MyImage.FileName);
   var contentType = model.MyImage.ContentType;

   // do something with the above data
   // to do : return something
   return View(new FirstTryImage());
}
    }
}