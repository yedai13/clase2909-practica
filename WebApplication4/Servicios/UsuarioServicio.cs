using System;
using System.Collections.Generic;
using WebApplication4.Models;

namespace WebApplication4.Servicios
{
    public class UsuarioServicio
    {
        private static List<Usuario> _usuarios = new List<Usuario>() {
            new Usuario(){
            Nombre = "Facundo",
            Apellido = "Marin",
            Edad = 27,
            Email= "facundo@gmail.com",
            Username = "facundo",
            Password = "facundo"
            }};
       
        
        public bool ValidarUsuario(string nombre, string password) {

            //TODO: validar el nombre y usuario con la colección _usuarios;
            Usuario usuario = new Usuario();
            usuario.Username=nombre;
            usuario.Password = password;

            return _usuarios.Exists(u => u.Password == usuario.Password && u.Username == usuario.Username);
        }

        public bool ValidarSiExisteElUsuario(Usuario usuario)
        {
            //(criterio : el email no esté registrado)
            return _usuarios.Exists(u => u.Email == usuario.Email && u.Username == usuario.Username);
        }

        internal void Registrar(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
    }
}
