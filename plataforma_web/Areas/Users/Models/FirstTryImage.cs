using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace plataforma_web.Areas.Users.Models
{
    public class FirstTryImage
    {
       public string ImageCaption { set;get; }
        public string ImageDescription { set;get; }
        public IFormFile MyImage { set; get; }
    }
}