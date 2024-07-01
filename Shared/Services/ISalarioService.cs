using PaginaWebCEAA.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebCEAA.Shared.Services
{
    public interface ISalarioService
    {

        public IEnumerable<SalarioEmpDTO> GetAllSalarioDTO();

        Task<SalarioEmpDTO> BuscarSalario(int id_emp);

        public void AddSalario(Salario salary);
        public void UpdateSalario(SalarioDTO salary);
        public void DeleteSalario(int? id_sal);
    }
}
