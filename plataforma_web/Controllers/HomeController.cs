﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using plataforma_web.Models;
using System.Web;


using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace plataforma_web.Controllers
{
    public class HomeController : Controller
    {
        
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        /*
        
        public async Task <string> subir(FileUploadAPI file){
            if(file !=null){
                String ruta = Microsoft.AspNetCore.Server.MapPath("~/Temp/");
                ruta += file.FileName;
            }
            return View();
        }*/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
