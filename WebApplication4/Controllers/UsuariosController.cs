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

        public IActionResult Registrar(Usuario usuario)
        {
            //TODO: Validar que el estado del model esté ok.
            if (ModelState.IsValid) {

                //TODO: Validar si el usuario ya no está registrado
                if (_servicio.ValidarSiExisteElUsuario(usuario)) {

                    //TODO: Si no está registrado, registrar usuario.
                    _servicio.Registrar(usuario);

                    //TODO: Definir hacia donde quiero llevar al usuario a nivel vistas.
                }
            }

            return View();
        }
    }
}
