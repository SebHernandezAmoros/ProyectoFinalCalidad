using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Models;

namespace TransportesYComercializaciónTRANSMI.Controllers
{
    public class AuthController : Controller
    {
        private DbEntities dbEntities;
        public AuthController(DbEntities dbEntities)
        {
            this.dbEntities = dbEntities;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            //Si el usuario existe en la base de datos generar la cookie, caso contrario mandar mensaje de error
            //if (DbEntities.Usuarios.Any(x => x.Username == Username && x.Password == Password))
            if(dbEntities.Empleados.Any(o => o.Usuario == Username && o.Clave == Password))
            {
                //Para crear la cookie necesitas todo esto
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, Username),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                //El autentifica y crea la cookie
                HttpContext.SignInAsync(claimsPrincipal);

                //Debe retornar a un menu con botones de:
                //El menu debe tener datos del empleado
                    //Ingreso paquete
                    //Ingreso de clientes
                    //Actualizacion de estado del paquete(Lista con buscador del paquete)
                return RedirectToAction("Init", "Auth");
            }

            ModelState.AddModelError("AuthError", "Usuario y/o contraseña incorrecta");
            if (!ModelState.IsValid)
            {
                return View("Login");
            }

            return View();
        }
        //Llamar a esta vista con un boton para desloguearte
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Init()
        {
            ViewBag.perfil = GetLoggedUser();

            return View();
        }

        private Empleado GetLoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var username = claim.Value;
            return dbEntities.Empleados.FirstOrDefault(o => o.Usuario == username);
        }
    }
}
