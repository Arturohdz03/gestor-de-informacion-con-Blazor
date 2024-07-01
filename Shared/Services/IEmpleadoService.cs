using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaginaWebCEAA.Shared.DTO;

namespace PaginaWebCEAA.Shared.Services
{
    public interface IEmpleadoService
    {
        //public Task<EmpleadoDTO> GetEmpleadoByIdAsync(int? id_emp);
        public IEnumerable<EmpleadoDTO> GetAllEmpleadosDTO();
        Task<EmpleadoDTO> BuscarEmpleado(int id_emp);
        public void AgregarEmpleado(EmpConDTO employed);
        public void UpdateEmpleado(EmpConDTO employed);
        public void DeleteEmpleado(int? id_emp);
        
    }
}
