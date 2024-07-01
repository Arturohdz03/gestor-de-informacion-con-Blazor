using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mapeo de clases concatenadas Empleado-Contrato
namespace PaginaWebCEAA.Shared.DTO
{
    public class EmpConDTO
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int id_emp { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_paterno { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_materno { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_sexo { get; set; }

        public DateTime emp_fecha_nacimiento { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_celular { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_correo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_curp { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_rfc { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_calle { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_num { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_col { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_mun { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_estado { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string emp_direc_cp { get; set; }

        public string? emp_arch_datos_generales { get; set; }
        public string? emp_arch_cv_solicitud { get; set; }
        public string? emp_arch_foto { get; set; }
        public string? emp_arch_acta_nacimiento { get; set; }
        public string? emp_arch_comprobante_estudios { get; set; }
        public string? emp_arch_rfc { get; set; }
        public string? emp_arch_curp { get; set; }
        public string? emp_arch_constancia_no_inhabilitacion { get; set; }
        public string? emp_arch_certificado_medico { get; set; }
        public string? emp_arch_credencial_elector { get; set; }
        public string? emp_arch_comprobante_domicilio { get; set; }
        public string? emp_arch_no_presta_servicios { get; set; }
        public string? emp_arch_solicitud_apertura_cuenta { get; set; }
        
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int est_id { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int pue_id { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int are_id { get; set; }

        public DateTime con_fecha_alta { get; set; } = DateTime.Now;
        public DateTime? con_fecha_baja { get; set; }
        
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int cat_id { get; set; }

    }
}
