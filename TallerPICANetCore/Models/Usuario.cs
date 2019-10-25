using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPICANetCore.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre de usuario es requerido", AllowEmptyStrings = false)]
        public string NombreUsuario
        {
            get;
            set;
        }
        [Required(ErrorMessage = "La contraseña es requerida", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Contrasenia
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Email es requerido")]
        [StringLength(100, ErrorMessage = "Logitud máxima 100")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email error")]
        [EmailAddress(ErrorMessage = "Correo electrónico incorrecto")]
        public string Email { get; set; }
    }
}
