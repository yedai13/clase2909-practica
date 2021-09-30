namespace WebApplication4.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Edad { get; set; }

        //DataAnnotations
        //TODO: Todos los campos son requeridos.
        //TODO: La edad debe ser mayor a 18 años.
        //TODO: Validar el formato de email.
    }
}
