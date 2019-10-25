using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TallerPICANetCore.Models;

namespace TallerPICANetCore.Controllers
{
    public class ContactoController : Controller
    {        
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Contacto(Contacto c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return RedirectToAction ("Index","Bienvenido" ,c);
                }
                catch (Exception)
                {
                    ErrorViewModel errorModel = new ErrorViewModel();
                    return View("Error", errorModel);
                }
            }

            return View(c);
        }
    }
}