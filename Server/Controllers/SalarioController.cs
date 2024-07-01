using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaginaWebCEAA.Server.Data;
using PaginaWebCEAA.Shared.Services;
using PaginaWebCEAA.Shared;
using PaginaWebCEAA.Shared.Models;
using PaginaWebCEAA.Shared.DTO;
using PaginaWebCEAA.Client.Pages;

namespace PaginaWebCEAA.Server.Controllers
{
    [Route("api/salario")]
    [ApiController]
    public class SalarioController : Controller
    {

        private readonly ISalarioService salarioServices;
        public SalarioController(ISalarioService _salarioServices)
        {

            salarioServices = _salarioServices;
        }

        //RUTA : https://localhost:44317/api/salario/get-salario-lista
        //METODO: Obtener salarios
        [HttpGet]
        [Route("get-salario-lista")]
        public async Task<IActionResult> GetSalarioList()
        {
            List<SalarioEmpDTO> salary = new List<SalarioEmpDTO>();

            salary = salarioServices.GetAllSalarioDTO().ToList();

            return Ok(salary);
        }

        //RUTA : https://localhost:44317/api/salario/get-salario/2
        //METODO: Obtener empleados
        [Route("get-salario/{id_emp}")]
        public async Task<IActionResult> BuscarSalarioID(int id_emp)
        {
            try
            {
                var salario = await salarioServices.BuscarSalario(id_emp);
                if (salario == null)
                {
                    return NotFound("No se encontró el empleado con el ID proporcionado.");
                }

                return Ok(salario);
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar el error
                return StatusCode(500, $"Ocurrió un error interno del servidor: {ex.Message}");
            }
        }


        //RUTA : https://localhost:44317/api/salario/post-salario
        //METODO: Agregar un salario
        [HttpPost]
        [Route("post-salario")]
        public async Task<IActionResult> AddSal(Salario salary)
        {
            try
            {
                salarioServices.AddSalario(salary);
                return Ok("Agregado exitozamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //RUTA :  https://localhost:44317/api/salario/update-salario
        //METODO: Actualizar un empleado
        [HttpPut]
        [Route("update-salario")]
        public async Task<IActionResult> Update(SalarioDTO salary)
        {
            try
            {
                salarioServices.UpdateSalario(salary);
                return Ok("Actualizado exitozamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //RUTA :   https://localhost:44317/api/salario/delete-salario/1
        //METODO: Eliminar un empleado
        [HttpDelete]
        [Route("delete-salario/{id_sal}")]
        public async Task<IActionResult> GetSalarioList(int id_sal)
        {

            salarioServices.DeleteSalario(id_sal);

            return Ok("Borrado exitozamente");
        }

    }
}
