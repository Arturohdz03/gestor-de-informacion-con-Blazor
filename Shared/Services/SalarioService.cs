using Microsoft.Extensions.Configuration;
using PaginaWebCEAA.Shared;
using PaginaWebCEAA.Shared.DTO;
using PaginaWebCEAA.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PaginaWebCEAA.Shared.Services
{
    public class SalarioService : ISalarioService
    {
        string connectionStrings = string.Empty;
        private readonly IConfiguration configuration;
        public SalarioService(IConfiguration _configuration)
        {
            connectionStrings = _configuration.GetConnectionString("DefaultConnection");
        }


        public async Task<SalarioEmpDTO> BuscarSalario(int id_emp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionStrings))
                {
                    SqlCommand cmd = new SqlCommand("vw_salariosSearch", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_emp", id_emp);

                    await con.OpenAsync();

                    using (SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                    {
                        if (await rdr.ReadAsync())
                        {
                            return new SalarioEmpDTO
                            {
                                id_sal = Convert.ToInt32(rdr["ID"]),

                                emp_nombre = rdr["NOMBRE"].ToString(),

                                sal_fecha = Convert.ToDateTime(rdr["FECHA"]),
                                sal_mensual_base = Convert.ToDecimal(rdr["MENSUAL_BASE"]),
                                sal_compensacion = Convert.ToDecimal(rdr["COMPENSACION"]),
                                sal_honorarios = Convert.ToDecimal(rdr["HONORARIOS"]),
                                sal_despensa = Convert.ToDecimal(rdr["DESPENSA"]),
                                sal_utiles = Convert.ToDecimal(rdr["UTILES"]),
                                sal_transporte = Convert.ToDecimal(rdr["TRANSPORTE"]),
                                sal_bruto = Convert.ToDecimal(rdr["BRUTO"]),
                                sal_neto = Convert.ToDecimal(rdr["NETO"]),

                                cat_nombre = rdr["CATEGORIA"].ToString(),
                                cat_tipo = rdr["TIPO"].ToString(),

                                sal_fuente = rdr["FUENTE"].ToString(),
                                sal_nombre_fondo = rdr["FONDO"].ToString(),
                                sal_observaciones = rdr["OBSERVACIONES"].ToString()
                            
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aquí podrías registrar el error y/o lanzar una excepción personalizada
                throw new Exception("Error al buscar el empleado por ID", ex);
            }

            return null; // o lanza una excepción si prefieres manejarlo de esa manera
        }

        public IEnumerable<SalarioEmpDTO> GetAllSalarioDTO()
        {
            List<SalarioEmpDTO> listSal = new List<SalarioEmpDTO>();

            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("vw_salariosAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SalarioEmpDTO SalDTO = new SalarioEmpDTO
                    {
                        id_sal = Convert.ToInt32(rdr["ID"]),

                        emp_nombre = rdr["NOMBRE"].ToString(),

                        sal_fecha = Convert.ToDateTime(rdr["FECHA"]),
                        sal_mensual_base = Convert.ToDecimal(rdr["MENSUAL_BASE"]),
                        sal_compensacion = Convert.ToDecimal(rdr["COMPENSACION"]),
                        sal_honorarios = Convert.ToDecimal(rdr["HONORARIOS"]),
                        sal_despensa = Convert.ToDecimal(rdr["DESPENSA"]),
                        sal_utiles = Convert.ToDecimal(rdr["UTILES"]),
                        sal_transporte = Convert.ToDecimal(rdr["TRANSPORTE"]),
                        sal_bruto = Convert.ToDecimal(rdr["BRUTO"]),
                        sal_neto = Convert.ToDecimal(rdr["NETO"]),

                        cat_nombre = rdr["CATEGORIA"].ToString(),
                        cat_tipo = rdr["TIPO"].ToString(),

                        sal_fuente = rdr["FUENTE"].ToString(),
                        sal_nombre_fondo = rdr["FONDO"].ToString(),
                        sal_observaciones = rdr["OBSERVACIONES"].ToString()
                    };

                    listSal.Add(SalDTO);
                }
                con.Close();
            }
            return listSal;
        }

        public void AddSalario(Salario salary)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_InsSalario", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@p_emp_id", salary.emp_id);
                cmd.Parameters.AddWithValue("@p_sal_fecha", (object)salary.sal_fecha);
                cmd.Parameters.AddWithValue("@p_sal_mensual_base", (object)salary.sal_mensual_base);
                cmd.Parameters.AddWithValue("@p_sal_compensacion", (object)salary.sal_compensacion);
                cmd.Parameters.AddWithValue("@p_sal_honorarios", (object)salary.sal_honorarios);
                cmd.Parameters.AddWithValue("@p_sal_despensa", (object)salary.sal_despensa);
                cmd.Parameters.AddWithValue("@p_sal_utiles", (object)salary.sal_utiles);
                cmd.Parameters.AddWithValue("@p_sal_transporte", (object)salary.sal_transporte);
                cmd.Parameters.AddWithValue("@p_sal_bruto", (object)salary.sal_bruto);
                cmd.Parameters.AddWithValue("@p_sal_neto", (object)salary.sal_neto);
                cmd.Parameters.AddWithValue("@p_sal_fuente", (object)salary.sal_fuente);
                cmd.Parameters.AddWithValue("@p_sal_nombre_fondo", (object)salary.sal_nombre_fondo);
                cmd.Parameters.AddWithValue("@p_sal_observaciones", salary.sal_observaciones);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateSalario(SalarioDTO salary)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdSalario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_sal_id", salary.id_sal);
                cmd.Parameters.AddWithValue("@p_sal_fecha", (object)salary.sal_fecha ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_mensual_base", (object)salary.sal_mensual_base ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_compensacion", (object)salary.sal_compensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_honorarios", (object)salary.sal_honorarios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_despensa", (object)salary.sal_despensa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_utiles", (object)salary.sal_utiles ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_transporte", (object)salary.sal_transporte ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_bruto", (object)salary.sal_bruto ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_neto", (object)salary.sal_neto ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_fuente", (object)salary.sal_fuente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_nombre_fondo", (object)salary.sal_nombre_fondo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_sal_observaciones", salary.sal_observaciones);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void DeleteSalario(int? id_sal)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_DelSalario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_sal_id", id_sal);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
    