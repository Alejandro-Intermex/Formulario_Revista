using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace revistas.Models
{

    public class Usuario
    {

        [key]

        public int id { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Codigo de Barras es obligatorio")]
        public string CB { get; set; }

        [Required(ErrorMessage = "La Fecha de Circulacion es obligatoria")]
        public string Fecha_circulacion { get; set; }

        [Required(ErrorMessage = "El Titulo es obligatorio")]
        public string Titulo { get; set; }

    }
}