using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using mvcVistaWeb.DAOs;
using mvcVistaWeb.Models;

namespace mvcVistaWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Mi build
            MiPropioMain();

            // Web Build
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void MiPropioMain()
        {
            //var connString = "Server=localhost;Database=usuarios;Uid=root;Pwd=;";
            //DBConnection.getInstance().connect(connString);
            UsuarioDAO.getInstancia();

        }

    }
}
