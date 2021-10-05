using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Servicios;

namespace WebApplication4.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioServicio _servicio = new UsuarioServicio();

        public IActionResult Registrar()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            //TODO: Validar que el estado del model esté ok.
            if (ModelState.IsValid) {

                //TODO: Validar si el usuario ya no está registrado
                if (_servicio.ValidarSiExisteElUsuario(usuario)) {

                    //TODO: Si no está registrado, registrar usuario.
                    //TODO: Definir hacia donde quiero llevar al usuario a nivel vistas.
                    ModelState.AddModelError(string.Empty, "El username/email ya estan en uso");
                    return View();
                }

                _servicio.Registrar(usuario);
            }

            return RedirectToAction("Login", "Home");
        }
    }
}
