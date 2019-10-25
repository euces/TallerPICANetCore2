using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TallerPICANetCore.Models;

namespace TallerPICANetCore.Controllers
{
    public class BienvenidoController : Controller
    {
        public IActionResult Index(Contacto c)
        {
            return View(c);
        }
    }
}