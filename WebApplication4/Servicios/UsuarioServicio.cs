using System;
using System.Collections.Generic;
using WebApplication4.Models;

namespace WebApplication4.Servicios
{
    public class UsuarioServicio
    {
        private static List<Usuario> _usuarios = new List<Usuario>();
        
        public bool ValidarUsuario(string nombre, string password) {

            //TODO: validar el nombre y usuario con la colección _usuarios;

            return nombre == "admin" && password == "admin123";
        }

        public bool ValidarSiExisteElUsuario(Usuario usuario)
        {
            //(criterio : el email no esté registrado)
            return _usuarios.Exists(u => u.Email == usuario.Email);
        }

        internal void Registrar(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
    }
}
