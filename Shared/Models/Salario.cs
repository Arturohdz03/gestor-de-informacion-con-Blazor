using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared
{
    public class Salario
    {
        [Key]
        
        public int id_sal { get; set; }
        [Required(ErrorMessage = "El campo fecha es requerido.")]

        public DateTime sal_fecha { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo mensual base es requerido.")]

        public decimal sal_mensual_base { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo compensación es requerido.")]

        public decimal sal_compensacion { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo honorarios es requerido.")]

        public decimal sal_honorarios { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo despensa es requerido.")]

        public decimal sal_despensa { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public decimal sal_utiles { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public decimal sal_transporte { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public decimal sal_bruto { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public decimal sal_neto { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public string sal_fuente { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public string sal_nombre_fondo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]

        public string sal_observaciones { get; set; }

        [Required][Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido.")]
        public int emp_id { get; set; }

    }
}


//CREATE TABLE salarios (
//	id_sal 					INT PRIMARY KEY IDENTITY(1,1),
//    sal_fecha 				DATE NOT NULL,
//    sal_mensual_base 		DECIMAL(10, 2) NOT NULL,
//    sal_compensacion 		DECIMAL(10, 2) NOT NULL,
//    sal_honorarios 			DECIMAL(10, 2) NOT NULL,
//    sal_despensa			DECIMAL(10, 2) NOT NULL,
//    sal_utiles				DECIMAL(10, 2) NOT NULL,
//    sal_transporte			DECIMAL(10, 2) NOT NULL,
//    sal_bruto 				DECIMAL(10, 2) NOT NULL,
//    sal_neto 				DECIMAL(10, 2) NOT NULL,
//    sal_fuente 				VARCHAR(10) NOT NULL,
//    sal_nombre_fondo 		VARCHAR(25) NOT NULL,
//    sal_observaciones 		TEXT,
//    emp_id 					INT
//);
//GO