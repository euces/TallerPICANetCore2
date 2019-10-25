using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using TallerPICANetCore.Auth;
using TallerPICANetCore.Models;

namespace TallerPICANetCore.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {
            if (ModelState.IsValid)
            {
                DapperUsersTable userAuth = new DapperUsersTable();
                var userIdentity = userAuth.CreateAsync(new ApplicationUser()
                {
                    Email = u.Email,
                    Password = u.Contrasenia,
                    UserName = u.NombreUsuario,
                });
                if (userIdentity.Result.Succeeded)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("user", "eulices"),
                        new Claim("role", "Admin")
                    };
                    HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies", "user", "role")));
                    return RedirectToAction("Contacto", "Contacto");
                }
                else
                {
                    ViewBag.Error = "Usuario invalido";
                }
            }            
            return View(u);
        }
    }
}
