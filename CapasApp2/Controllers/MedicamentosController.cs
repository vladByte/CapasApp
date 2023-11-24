using System.IO;
using System;
using System.Data;
using System.ComponentModel.Design.Serialization;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;

namespace CapasApp2.Controllers
{
    public class MedicamentosController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public string Cadena()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(),"appsettings.json"));
            var root = builder.Build();
            var db = root.GetConnectionString("cnx");
            return db; 
        }
     
    }
}