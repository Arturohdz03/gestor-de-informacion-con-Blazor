using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared
{

    public class Empleado
    {
        [Key]
        public int id_emp { get; set; }
        public string? emp_nombre { get; set; }
        public string? emp_paterno { get; set; }
        public string? emp_materno { get; set; }
        public string? emp_sexo { get; set; }
        public DateTime? emp_fecha_nacimiento { get; set; }
        public string? emp_celular { get; set; }
        public string? emp_correo { get; set; }
        public string? emp_curp { get; set; }
        public string? emp_rfc { get; set; }
        public string? emp_direc_calle { get; set; }
        public string? emp_direc_num { get; set; }
        public string? emp_direc_col { get; set; }
        public string? emp_direc_mun { get; set; }
        public string? emp_direc_estado { get; set; }
        public string? emp_direc_cp { get; set; }

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
        
        public int? est_id { get; set; }
        public int? pue_id { get; set; }
        public int? are_id { get; set; }
     
        public int con_id { get; set; }

    }

}

//id_emp INT PRIMARY KEY,
//emp_nombre	 			VARCHAR(25) NOT NULL,
//emp_paterno 			VARCHAR(25) NOT NULL,
//emp_materno 			VARCHAR(25) NOT NULL,
//emp_sexo 				VARCHAR(30) CHECK (EMP_SEXO IN ('HOMBRE', 'MUJER')) NOT NULL,
//emp_fecha_nacimiento 	DATE NOT NULL,
//emp_celular 			VARCHAR(17) NOT NULL,
//emp_correo 				VARCHAR(40) NOT NULL,
//emp_curp 				VARCHAR(18) NOT NULL,
//emp_rfc 				VARCHAR(13) NOT NULL,
//emp_direc_calle			VARCHAR(30) NOT NULL,
//emp_direc_num 			VARCHAR(5) NOT NULL,
//emp_direc_col 			VARCHAR(30) NOT NULL,
//emp_direc_mun 			VARCHAR(30) NOT NULL,
//emp_direc_estado 		VARCHAR(30) NOT NULL,
//emp_direc_cp 			VARCHAR(5) NOT NULL,

//emp_arch_datos_generales 				VARBINARY(MAX),
//emp_arch_cv_solicitud 					VARBINARY(MAX),
//emp_arch_foto 							VARBINARY(MAX),
//emp_arch_acta_nacimiento 				VARBINARY(MAX),
//emp_arch_comprobante_estudios 			VARBINARY(MAX),
//emp_arch_rfc 							VARBINARY(MAX),
//emp_arch_curp 							VARBINARY(MAX),
//emp_arch_constancia_no_inhabilitacion 	VARBINARY(MAX),
//emp_arch_certificado_medico 			VARBINARY(MAX),
//emp_arch_credencial_elector 			VARBINARY(MAX),
//emp_arch_comprobante_domicilio 			VARBINARY(MAX),
//emp_arch_no_presta_servicios 			VARBINARY(MAX),
//emp_arch_solicitud_apertura_cuenta 		VARBINARY(MAX),

//ceaa_id 				INT 		NOT NULL,
//are_id 					INT 		NOT NULL,
//est_id 					INT 		NOT NULL,
//con_id 					INT


