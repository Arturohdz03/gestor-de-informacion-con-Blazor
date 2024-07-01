using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared.Models
{
    public class Estudio
    {
        [Key]
        public int id_est { get; set; }
        public string? est_max { get; set; }
        public string? est_nivel { get; set; }
    }
}


//CREATE TABLE estudios (
//	id_est					INT PRIMARY KEY,
//    est_max 				VARCHAR(15) NOT NULL,
//    est_nivel 				VARCHAR(8) 	NOT NULL
//);
//GO