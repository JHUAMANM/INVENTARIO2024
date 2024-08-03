using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class UsuarioAplicacion : IdentityUser
    {
        [Required(ErrorMessage ="Nombre Requerido")]
        [MaxLength(80)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Apellidos Requerido")]
        [MaxLength(80)]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Dirección Requerido")]
        [MaxLength(200)]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Ciudad Requerido")]
        [MaxLength(60)]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "Pais Requerido")]
        [MaxLength(60)]
        public string Pais { get; set; }


        [NotMapped] //No se agrega a la base de datos
        public string Role { get; set; }

    }
}
