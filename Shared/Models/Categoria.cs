using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared.Models
{
    public class Categoria
    {
        [Key]
        public int id_cat { get; set; }
        public string? cat_nombre { get; set; }
        public string? cat_tipo { get; set; }
    }
}

//CREATE TABLE categorias (
//	id_cat					INT PRIMARY KEY,
//    cat_nombre 				VARCHAR(11) NOT NULL,
//    cat_tipo 				VARCHAR(10) NOT NULL
//);
//GO