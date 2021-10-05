using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="Debe ingrasar nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingrasar apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingrasar email")]
        [EmailAddress(ErrorMessage ="Debe ingresar un email correcto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingrasar username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Debe ingrasar password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Debe ingrasar edad")]
        [Range(18, 100, ErrorMessage = "Debes ser mayor de 18 años")]
        public int Edad { get; set; }

        //DataAnnotations
        //TODO: Todos los campos son requeridos.
        //TODO: La edad debe ser mayor a 18 años.
        //TODO: Validar el formato de email.
    }
}
