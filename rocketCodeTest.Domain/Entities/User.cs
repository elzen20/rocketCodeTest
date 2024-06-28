using System.ComponentModel.DataAnnotations;

namespace rocketCodeTest.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        public string? SegundoNombre { get; set; }

        [Required(ErrorMessage = "El apellido paterno es obligatorio")]
        public required string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El apellido materno es obligatorio")]
        public required string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime FechaDeNacimiento { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email no es válido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Range(10000000, 99999999, ErrorMessage = "Tienen que ser 8 caracteres.")]
        public required string Telefono { get; set; }
    }
}
