using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Semana_16_2.Controllers
{
    public class HellowWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Esta es la acción de bienvenida";
        }
        public string Parameters(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es de: {edad}, anos");
        }
            
            
        
        
    }
}
