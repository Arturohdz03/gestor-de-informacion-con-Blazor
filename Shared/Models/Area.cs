using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared
{
    public class Area
    {
        [Key]
        public int id_are { get; set; }
        public string? are_nombre { get; set; }
        public int? are_ads { get; set; }
    }
}
//CREATE TABLE areas (
//	id_are 					INT PRIMARY KEY,
//    are_nombre 				VARCHAR(67) NOT NULL,
//    are_ads 				INT 		NOT NULL,
//);
//GO