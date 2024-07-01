using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared.Models
{
    public class Puesto
    {
        [Key]
        public int id_pue { get; set; }
        public string? pue_nombre { get; set; }
        public string? pue_nivel { get; set;
        }
    }
}


//CREATE TABLE puestos (
//	id_pue 					INT PRIMARY KEY,
//    pue_nombre 				VARCHAR(22) NOT NULL,
//    pue_nivel				VARCHAR(3) 	NOT NULL
//);
//GO