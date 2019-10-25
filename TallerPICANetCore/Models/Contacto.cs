using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPICANetCore.Models
{
    public class Contacto
    {
        [Required(ErrorMessage = "El nombre es requerido", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email error")]
        [EmailAddress(ErrorMessage = "Correo electrónico incorrecto")]
        public string Email { get; set; }

        [StringLength(10, ErrorMessage = "Logitud máxima 100")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Debe ser numero")]
        public string Telefono { get; set; }

        [StringLength(255, ErrorMessage = "Logitud máxima 255")]
        public string Descripcion { get; set; }

    }
}
