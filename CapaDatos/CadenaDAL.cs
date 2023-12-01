﻿using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos 
{
    public class CadenaDAL
    {
        public string CadenaCnx { get; set; }

        public CadenaDAL()
        { 
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            CadenaCnx = root.GetConnectionString("cnx");
        }
    }
}
