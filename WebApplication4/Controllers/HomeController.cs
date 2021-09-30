using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Servicios;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UsuarioServicio _servicio = new UsuarioServicio();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Login");
        }


        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (_servicio.ValidarUsuario(model.Usuario, model.Password))
                {
                    return RedirectToAction("Home");
                }

                ModelState.AddModelError(string.Empty, "Usuario no valido");
                return View(model);
            }

            return View();
        }

        public IActionResult Home()
        {

            return View();
        }

        public IActionResult Registrar() {

            return View();
        }

        public IActionResult Logout()
        {

            TempData["Mensaje"] = "Gracias por haber usado nuestra plataforma!!";
            return RedirectToAction("Index");
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
