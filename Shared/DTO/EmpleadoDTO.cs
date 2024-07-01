using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace PaginaWebCEAA.Shared.DTO
{
    public class EmpleadoDTO
    {
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int id_emp { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_nombre { get; set; } = null!;
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_celular { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_correo { get; set; }

        public PuestoDTO Puesto { get; set; }
        public AreaDTO Area { get; set; }
    }
}
