using Microsoft.Extensions.Configuration;
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
    public class EmpleadoService: IEmpleadoService
    {
        string connectionStrings = string.Empty;
        private readonly IConfiguration configuration;
        public EmpleadoService(IConfiguration _configuration)
        {
            connectionStrings = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<EmpleadoDTO> BuscarEmpleado(int id_emp)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionStrings))
                {
                    SqlCommand cmd = new SqlCommand("vw_empleadoSearch", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_emp", id_emp);

                    await con.OpenAsync();

                    using (SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                    {
                        if (await rdr.ReadAsync())
                        {
                            return new EmpleadoDTO
                            {
                                id_emp = rdr["ID"] != DBNull.Value ? Convert.ToInt32(rdr["ID"]) : 0,
                                emp_nombre = rdr["NOMBRE"]?.ToString(),
                                emp_celular = rdr["CELULAR"]?.ToString(),
                                emp_correo = rdr["CORREO"]?.ToString(),
                                Puesto = new PuestoDTO
                                {
                                    pue_nombre = rdr["PUESTO"]?.ToString(),
                                    pue_nivel = rdr["NIVEL_JERARQUICO"]?.ToString()
                                },
                                Area = new AreaDTO
                                {
                                    are_nombre = rdr["AREA"]?.ToString()
                                }
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


        public IEnumerable<EmpleadoDTO> GetAllEmpleadosDTO()
        {
            List<EmpleadoDTO> listEmp = new List<EmpleadoDTO>();

            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("vw_empleadoTable", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EmpleadoDTO EmpDTO = new EmpleadoDTO
                    {
                        id_emp = Convert.ToInt32(rdr["ID"]),
                        emp_nombre = rdr["NOMBRE"].ToString(),
                        emp_celular = rdr["CELULAR"].ToString(),
                        emp_correo = rdr["CORREO"].ToString(),
                        Puesto = new PuestoDTO
                        {
                            pue_nombre = rdr["PUESTO"].ToString(),
                            pue_nivel = rdr["NIVEL_JERARQUICO"].ToString()
                        },
                        Area = new AreaDTO
                        {
                            are_nombre = rdr["AREA"].ToString()
                        }
                    };

                    listEmp.Add(EmpDTO);
                }
                con.Close();
            }

            return listEmp;
        }

        public void AgregarEmpleado(EmpConDTO employed)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_InsEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@p_id_emp", employed.id_emp);
                cmd.Parameters.AddWithValue("@p_emp_nombre", employed.emp_nombre);
                cmd.Parameters.AddWithValue("@p_emp_paterno", employed.emp_paterno);
                cmd.Parameters.AddWithValue("@p_emp_materno", employed.emp_materno);
                cmd.Parameters.AddWithValue("@p_emp_sexo", employed.emp_sexo);
                cmd.Parameters.AddWithValue("@p_emp_fecha_nacimiento", employed.emp_fecha_nacimiento);
                cmd.Parameters.AddWithValue("@p_emp_celular", employed.emp_celular);
                cmd.Parameters.AddWithValue("@p_emp_correo", employed.emp_correo);
                cmd.Parameters.AddWithValue("@p_emp_curp", employed.emp_curp);
                cmd.Parameters.AddWithValue("@p_emp_rfc", employed.emp_rfc);
                cmd.Parameters.AddWithValue("@p_emp_direc_calle", employed.emp_direc_calle);
                cmd.Parameters.AddWithValue("@p_emp_direc_num", employed.emp_direc_num);
                cmd.Parameters.AddWithValue("@p_emp_direc_col", employed.emp_direc_col);
                cmd.Parameters.AddWithValue("@p_emp_direc_mun", employed.emp_direc_mun);
                cmd.Parameters.AddWithValue("@p_emp_direc_estado", employed.emp_direc_estado);
                cmd.Parameters.AddWithValue("@p_emp_direc_cp", employed.emp_direc_cp);

                cmd.Parameters.AddWithValue("@p_emp_arch_datos_generales", (object)employed.emp_arch_datos_generales ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_cv_solicitud", (object)employed.emp_arch_cv_solicitud ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_foto", (object)employed.emp_arch_foto ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_acta_nacimiento", (object)employed.emp_arch_acta_nacimiento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_comprobante_estudios", (object)employed.emp_arch_comprobante_estudios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_rfc", (object)employed.emp_arch_rfc ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_curp", (object)employed.emp_arch_curp ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_constancia_no_inhabilitacion", (object)employed.emp_arch_constancia_no_inhabilitacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_certificado_medico", (object)employed.emp_arch_certificado_medico ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_credencial_elector", (object)employed.emp_arch_credencial_elector ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_comprobante_domicilio", (object)employed.emp_arch_comprobante_domicilio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_no_presta_servicios", (object)employed.emp_arch_no_presta_servicios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_solicitud_apertura_cuenta", (object)employed.emp_arch_solicitud_apertura_cuenta ?? DBNull.Value);


                cmd.Parameters.AddWithValue("@p_est_id", employed.est_id);
                cmd.Parameters.AddWithValue("@p_pue_id", employed.pue_id);
                cmd.Parameters.AddWithValue("@p_are_id", employed.are_id);

                cmd.Parameters.AddWithValue("@p_con_fecha_alta", employed.con_fecha_alta);
                cmd.Parameters.AddWithValue("@p_con_fecha_baja", (object)employed.con_fecha_baja ?? DBNull.Value); // Manejo de valores nulos

                cmd.Parameters.AddWithValue("@p_cat_id", employed.cat_id);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateEmpleado(EmpConDTO employed)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@p_id_emp", employed.id_emp);
                cmd.Parameters.AddWithValue("@p_emp_nombre", employed.emp_nombre);
                cmd.Parameters.AddWithValue("@p_emp_paterno", employed.emp_paterno);
                cmd.Parameters.AddWithValue("@p_emp_materno", employed.emp_materno);
                cmd.Parameters.AddWithValue("@p_emp_sexo", employed.emp_sexo);
                cmd.Parameters.AddWithValue("@p_emp_fecha_nacimiento", employed.emp_fecha_nacimiento);
                cmd.Parameters.AddWithValue("@p_emp_celular", employed.emp_celular);
                cmd.Parameters.AddWithValue("@p_emp_correo", employed.emp_correo);
                cmd.Parameters.AddWithValue("@p_emp_curp", employed.emp_curp);
                cmd.Parameters.AddWithValue("@p_emp_rfc", employed.emp_rfc);
                cmd.Parameters.AddWithValue("@p_emp_direc_calle", employed.emp_direc_calle);
                cmd.Parameters.AddWithValue("@p_emp_direc_num", employed.emp_direc_num);
                cmd.Parameters.AddWithValue("@p_emp_direc_col", employed.emp_direc_col);
                cmd.Parameters.AddWithValue("@p_emp_direc_mun", employed.emp_direc_mun);
                cmd.Parameters.AddWithValue("@p_emp_direc_estado", employed.emp_direc_estado);
                cmd.Parameters.AddWithValue("@p_emp_direc_cp", employed.emp_direc_cp);

                cmd.Parameters.AddWithValue("@p_emp_arch_datos_generales", (object)employed.emp_arch_datos_generales ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_cv_solicitud", (object)employed.emp_arch_cv_solicitud ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_foto", (object)employed.emp_arch_foto ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_acta_nacimiento", (object)employed.emp_arch_acta_nacimiento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_comprobante_estudios", (object)employed.emp_arch_comprobante_estudios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_rfc", (object)employed.emp_arch_rfc ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_curp", (object)employed.emp_arch_curp ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_constancia_no_inhabilitacion", (object)employed.emp_arch_constancia_no_inhabilitacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_certificado_medico", (object)employed.emp_arch_certificado_medico ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_credencial_elector", (object)employed.emp_arch_credencial_elector ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_comprobante_domicilio", (object)employed.emp_arch_comprobante_domicilio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_no_presta_servicios", (object)employed.emp_arch_no_presta_servicios ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@p_emp_arch_solicitud_apertura_cuenta", (object)employed.emp_arch_solicitud_apertura_cuenta ?? DBNull.Value);


                cmd.Parameters.AddWithValue("@p_est_id", employed.est_id);
                cmd.Parameters.AddWithValue("@p_pue_id", employed.pue_id);
                cmd.Parameters.AddWithValue("@p_are_id", employed.are_id);

                cmd.Parameters.AddWithValue("@p_con_fecha_alta", employed.con_fecha_alta);
                cmd.Parameters.AddWithValue("@p_con_fecha_baja", (object)employed.con_fecha_baja ?? DBNull.Value); // Manejo de valores nulos

                cmd.Parameters.AddWithValue("@p_cat_id", employed.cat_id);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void DeleteEmpleado(int? id_emp)
        {
            using (SqlConnection con = new SqlConnection(connectionStrings))
            {
                SqlCommand cmd = new SqlCommand("sp_DelEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_emp", id_emp);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

}
