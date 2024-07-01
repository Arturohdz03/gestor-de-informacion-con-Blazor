using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared
{
    public class Contrato
    {
        [Key]
        public int id_con { get; set; }
        public DateTime? con_fecha_alta { get; set; }
        public DateTime con_fecha_baja { get; set; }
        public int cat_id { get; set; }
        public int emp_id { get; set; }
    }
}


//CREATE TABLE contratos (
//	id_con 					INT PRIMARY KEY,
//    con_fecha_alta 			DATE NOT NULL,
//    con_fecha_baja 			DATE,
//    cat_id 					INT,
//    emp_id 					INT
//);
//GO