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
    [Route("api/empleados")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly IEmpleadoService empleadoServices;
        public EmpleadoController(IEmpleadoService _empleadoServices)
        {

            empleadoServices = _empleadoServices;
        }

        //RUTA : https://localhost:44317/api/empleados/get-empleados-lista
        //METODO: Obtener empleados
        [HttpGet]
        [Route("get-empleados-lista")]
        public async Task<IActionResult> GetEmpleadoList()
        {

            List<EmpleadoDTO> employed = new List<EmpleadoDTO>();

            employed = empleadoServices.GetAllEmpleadosDTO().ToList();


            return Ok(employed);
        }

        //RUTA : https://localhost:44317/api/empleados/get-empleado
        //METODO: Obtener empleados
        [HttpGet("get-empleado/{id_emp}")]
        public async Task<IActionResult> BuscarEmpleadoPorId(int id_emp)
        {
            try
            {
                var empleado = await empleadoServices.BuscarEmpleado(id_emp);
                if (empleado == null)
                {
                    return NotFound("No se encontró el empleado con el ID proporcionado.");
                }

                return Ok(empleado);
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar el error
                return StatusCode(500, $"Ocurrió un error interno del servidor: {ex.Message}");
            }
        }



        //RUTA : https://localhost:44317/api/empleados/post-empleado
        //METODO: Agregar un empleado
        [HttpPost]
        [Route("post-empleado")]
        public async Task<IActionResult> AddEmp(EmpConDTO employed)
        {
            try
            {
                empleadoServices.AgregarEmpleado(employed);
                return Ok("Agregado exitozamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //RUTA : https://localhost:44317/api/empleados/update-empleado
        //METODO: Actualizar un empleado
        [HttpPut]
        [Route("update-empleado")]
        public async Task<IActionResult> UpdateEmployed(EmpConDTO employed)
        {
            try
            {
                empleadoServices.UpdateEmpleado(employed);
                return Ok("Actualizado exitozamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //RUTA : https://localhost:44317/api/empleados/delete-student/2
        //METODO: Eliminar un empleado
        [HttpDelete]
        [Route("delete-empleado/{id_emp}")]
        public async Task<IActionResult> DeleteEmployed(int id_emp)
        {

            empleadoServices.DeleteEmpleado(id_emp);

            return Ok("Borrado exitozamente");
        }

    }
}
