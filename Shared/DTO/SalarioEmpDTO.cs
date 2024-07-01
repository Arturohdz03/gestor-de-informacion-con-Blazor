using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mapeo de clases concatenadas Salario-Emp

namespace PaginaWebCEAA.Shared.DTO
{
    public class SalarioEmpDTO
    {
        public int id_sal { get; set; }
        public string emp_nombre { get; set; } = null!;
        public DateTime sal_fecha { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_mensual_base { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_compensacion { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_honorarios { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_despensa { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_utiles { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_transporte { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_bruto { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? sal_neto { get; set; }
        public string? sal_fuente { get; set; }
        public string? sal_nombre_fondo { get; set; }
        public string sal_observaciones { get; set; }
        public string? cat_nombre { get; set; }
        public string? cat_tipo { get; set; }
    }
}


//s.id_sal AS ID,
//s.sal_fecha AS FECHA,
//s.sal_mensual_base AS MENSUAL_BASE,
//s.sal_compensacion AS COMPENSACION,
//s.sal_honorarios AS HONORARIOS,
//s.sal_despensa AS DESPENSA,
//s.sal_utiles AS UTILES,
//s.sal_transporte AS TRANSPORTE,
//s.sal_bruto AS BRUTO,
//s.sal_neto AS NETO,
//cat.cat_nombre AS CATEGORIA,
//cat.cat_tipo AS TIPO,
//s.sal_fuente AS FUENTE,
//s.sal_nombre_fondo AS FONDO,
//s.sal_observaciones AS OBSERVACIONES

//CONCAT(e.emp_nombre, ' ', e.emp_paterno, ' ', e.emp_materno) AS NOMBRE,

