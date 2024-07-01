using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared.DTO
{

    public class SalarioDTO
    {
        public int id_sal { get; set; }
        public DateTime? sal_fecha { get; set; }
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
    }
}