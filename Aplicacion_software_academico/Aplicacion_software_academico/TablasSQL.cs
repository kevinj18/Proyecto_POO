using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Aplicacion_software_academico.TablasSQL;
using System.IO;
using System.ComponentModel.Design.Serialization;


namespace Aplicacion_software_academico
{

    internal class TablasSQL
    {
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public class Asignatura
        {
            cConexion conexion = new cConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            private int idAsignatura;
            private string nombreAsignatura;
            private string creditos;
            private int idProfesor;

            public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
            public string NombreAsignatura { get => nombreAsignatura; set => nombreAsignatura = value; }
            public string Creditos { get => creditos; set => creditos = value; }
            public int IdProfesor { get => idProfesor; set => idProfesor = value; }
            public string registrarAsignatura(string idProfesor, string nombreAsignatura, string creditos)
            {
                try
                {
                    using (SqlConnection conn = conexion.AbrirConexion())
                    {
                        string query = "insert into Asignatura (nombre, creditos, id_profesor) " +
                                        "output inserted.id_asignatura " +
                                        "values (@nombreAsignatura, @creditos, @idProfesor)";
                        int idAsignatura;
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@nombreAsignatura", nombreAsignatura);
                        cmd.Parameters.AddWithValue("@creditos", creditos);
                        cmd.Parameters.AddWithValue("@idProfesor", idProfesor);
                        idAsignatura = (int)cmd.ExecuteScalar();
                        return "Asignatura registrada correctamente";
                    }

                }
                catch (Exception ex)
                {
                    return "Error al registrar asignatura: " + ex.Message;
                }
            }
        }
        public class Usuario
        {
            cConexion conexion = new cConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            private int idUsuario;
            private string nombre;
            private string correo;
            private string contrasena;
            private string rol;

            public int IdUsuario { get => idUsuario; set => idUsuario = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Correo { get => correo; set => correo = value; }
            public string Rol { get => rol; set => rol = value; }
            public string Contrasena { get => contrasena; set => contrasena = value; }
            public string Semestre { get; set; }
            public DateTime? FechaIngreso { get; set; }
            public string Especialidad { get; set; }
            public DateTime? FechaContratacion { get; set; }
            public string Cargo { get; set; }


            // Valida si el usuario existe en la base de datos
            public string validarUsuario(string correo, string contraseña)
            {
                string query = @"
                select u.contrasena, u.rol, 
                e.id_estudiante, 
                p.id_profesor,
                a.id_admin
                from usuario u
                left join estudiante e on u.id_usuario = e.id_usuario
                left join profesor p on u.id_usuario = p.id_usuario
                left join administrador a on u.id_usuario = a.id_usuario
                where u.correo = @correo";


                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                comando.Parameters.AddWithValue("@correo", correo);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string contrasenaBD = reader["contrasena"].ToString();

                        if (contrasenaBD == contraseña)
                        {
                            string rol = reader["rol"].ToString();

                            // Guardar la sesión
                            SesionActual.Correo = correo;
                            SesionActual.Rol = rol;

                            if (rol.ToLower() == "estudiante" && reader["id_estudiante"] != DBNull.Value)
                            {
                                SesionActual.IdEstudiante = Convert.ToInt32(reader["id_estudiante"]);
                            }
                            else if (rol.ToLower() == "profesor" && reader["id_profesor"] != DBNull.Value)
                            {
                                SesionActual.IdProfesor = Convert.ToInt32(reader["id_profesor"]);
                            }
                            else if (rol.ToLower() == "administrador" && reader["id_admin"] != DBNull.Value)
                            {
                                SesionActual.IdAdmin = Convert.ToInt32(reader["id_admin"]);
                            }

                                return rol;
                        }
                        else
                        {
                            return "Contraseña incorrecta";
                        }
                    }
                    else
                    {
                        return "Usuario no encontrado";
                    }




                }


            }
            // Registra un nuevo usuario en la base de datos
            public static string registrarUsuario(string nombre,
                                                  string correo,
                                                  string contrasena,
                                                  string rol,
                                                  string semestre = null,
                                                  DateTime? fechaIngreso = null,
                                                  string especialidad = null,
                                                  DateTime? fechaContratacion = null,
                                                  string cargo = null)
            {
                string resultado = "";
                cConexion conexion = new cConexion();
                SqlConnection conn = null;

                try
                {
                    conn = conexion.AbrirConexion();

                    string queryUsuario = @"INSERT INTO Usuario (nombre, correo, contrasena, rol)
                                OUTPUT INSERTED.id_usuario
                                VALUES (@nombre, @correo, @contrasena, @rol)";

                    SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conn);
                    cmdUsuario.Parameters.AddWithValue("@nombre", nombre);
                    cmdUsuario.Parameters.AddWithValue("@correo", correo);
                    cmdUsuario.Parameters.AddWithValue("@contrasena", contrasena);
                    cmdUsuario.Parameters.AddWithValue("@rol", rol);

                    int idUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());

                    // Inserta según el rol
                    switch (rol.ToLower())
                    {
                        case "estudiante":
                            string queryEst = "INSERT INTO Estudiante (id_usuario, semestre, fecha_ingreso) VALUES (@idUsuario, @semestre, @fechaIngreso)";
                            SqlCommand cmdEst = new SqlCommand(queryEst, conn);
                            cmdEst.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdEst.Parameters.AddWithValue("@semestre", semestre);
                            cmdEst.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                            cmdEst.ExecuteNonQuery();
                            break;

                        case "profesor":
                            string queryProf = "INSERT INTO Profesor (id_usuario, especialidad, fecha_contratacion) VALUES (@idUsuario, @especialidad, @fechaContratacion)";
                            SqlCommand cmdProf = new SqlCommand(queryProf, conn);
                            cmdProf.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdProf.Parameters.AddWithValue("@especialidad", especialidad);
                            cmdProf.Parameters.AddWithValue("@fechaContratacion", fechaContratacion);
                            cmdProf.ExecuteNonQuery();
                            break;

                        case "administrador":
                            string queryAdmin = "INSERT INTO Administrador (id_usuario, cargo) VALUES (@idUsuario, @cargo)";
                            SqlCommand cmdAdmin = new SqlCommand(queryAdmin, conn);
                            cmdAdmin.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdAdmin.Parameters.AddWithValue("@cargo", cargo);
                            cmdAdmin.ExecuteNonQuery();
                            break;
                    }

                    return "✅ Usuario registrado correctamente: ";
                }
                catch (Exception ex)
                {
                    return "❌ Error al registrar usuario " + nombre + ": " + ex.Message;
                }
                finally
                {
                    // Asegura cierre limpio
                    conexion.CerrarConexion();

                }
            }



        }

        public class Estudiante
        {
            
            public int IdEstudiante { get; set; }
            public int IdUsuario { get; set; }  
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public int Semestre { get; set; }

            private cConexion conexion = new cConexion();
            // Métodos
            public Estudiante ObtenerPorId(int id)
            {
                Estudiante estudiante = null;

                string query = @"select e.id_estudiante, u.id_usuario, u.nombre, u.correo, e.semestre
                         from Estudiante e
                         inner join Usuario u on e.id_usuario = u.id_usuario
                         where e.id_estudiante = @id";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estudiante = new Estudiante
                        {
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["nombre"].ToString(),
                            Correo = reader["correo"].ToString(),
                            Semestre = Convert.ToInt32(reader["semestre"])
                        };
                    }
                }

                conexion.CerrarConexion();
                return estudiante;
            }

            public DataTable ObtenerEstudiantesPorAsignatura(int idAsignatura)
            {
                string query = @"
                    select e.id_estudiante, 
                    u.nombre as nombrecompleto
                    from Estudiante e
                    inner join Usuario u on e.id_usuario = u.id_usuario
                    inner join Estudiante_Asignatura ea on e.id_estudiante = ea.id_estudiante
                    where ea.id_asignatura = @idAsignatura";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexion.CerrarConexion();
                return dt;
            }

            public List<Estudiante> ObtenerTodos()
            {
                List<Estudiante> lista = new List<Estudiante>();

                string query = @"select e.id_estudiante, u.id_usuario, u.nombre, u.correo, e.semestre
                         from Estudiante e
                         inner join Usuario u on e.id_usuario = u.id_usuario";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Estudiante
                        {
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["nombre"].ToString(),
                            Correo = reader["correo"].ToString(),
                            Semestre = Convert.ToInt32(reader["semestre"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            public int ObtenerIdEstudiantePorCorreo(string correo)
            {
                int id = -1;

                string query = @"select e.id_estudiante
                     from estudiante e
                     inner join usuario u on e.id_usuario = u.id_usuario
                     where u.correo = @correo";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@correo", correo);

                object result = comando.ExecuteScalar();

                if (result != null)
                    id = Convert.ToInt32(result);

                conexion.CerrarConexion();
                return id;
            }

        }

        public class Calificacion
        {
            public int IdCalificacion { get; set; }
            public int IdEstudiante { get; set; }
            public int IdAsignatura { get; set; }
            public decimal? Nota1 { get; set; }
            public decimal? Nota2 { get; set; }
            public decimal? Nota3 { get; set; }
            public decimal? Nota4 { get; set; }
            public decimal NotaFinal { get; set; }
            public DateTime FechaRegistro { get; set; }

            private cConexion conexion = new cConexion();


            public DataTable ObtenerNotasPorEstudianteYAsignatura(int idEstudiante, int idAsignatura)
            {
                string query = @"
                select id_calificacion, nota, fecha_registro
                from calificacion
                where id_estudiante = @idEstudiante and id_asignatura = @idAsignatura";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexion.CerrarConexion();
                return dt;
            }

            public bool ModificarNota(int idCalificacion, decimal nuevaNota)
            {
                string query = "update calificacion set nota = @nuevaNota, fecha_registro = getdate() where id_calificacion = @idCalificacion";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@nuevaNota", nuevaNota);
                comando.Parameters.AddWithValue("@idCalificacion", idCalificacion);

                int filas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();

                return filas > 0;
            }

            // obtener calificación por id
            //public Calificacion ObtenerPorId(int id)
            //{
            //    Calificacion calificacion = null;

            //    string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
            //                    c.nota, c.fecha_registro
            //             from calificacion c
            //             where c.id_calificacion = @id";

            //    SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            //    comando.Parameters.AddWithValue("@id", id);

            //    using (SqlDataReader reader = comando.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            calificacion = new Calificacion
            //            {
            //                IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
            //                IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
            //                IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
            //                Nota = Convert.ToDecimal(reader["nota"]),
            //                FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
            //            };
            //        }
            //    }

            //    conexion.CerrarConexion();
            //    return calificacion;
            //}

            // obtener todas las calificaciones de un estudiante
            //public List<Calificacion> ObtenerPorEstudiante(int idEstudiante)
            //{
            //    List<Calificacion> lista = new List<Calificacion>();

            //    string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
            //                    c.nota, c.fecha_registro
            //             from calificacion c
            //             where c.id_estudiante = @idEstudiante";

            //    SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            //    comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            //    using (SqlDataReader reader = comando.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            lista.Add(new Calificacion
            //            {
            //                IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
            //                IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
            //                IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
            //                Nota = Convert.ToDecimal(reader["nota"]),
            //                FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
            //            });
            //        }
            //    }

            //    conexion.CerrarConexion();
            //    return lista;
            //}

            public List<Calificacion> ObtenerPorEstudianteYAsignatura(int idEstudiante, int? idAsignatura = null)
            {
                List<Calificacion> lista = new List<Calificacion>();

                string query = @"SELECT c.id_calificacion, c.id_estudiante, c.id_asignatura,
                            c.nota1, c.nota2, c.nota3, c.nota4, 
                            c.nota_final, c.fecha_registro
                     FROM Calificacion c
                     WHERE c.id_estudiante = @idEstudiante";

                if (idAsignatura.HasValue)
                {
                    query += " AND c.id_asignatura = @idAsignatura";
                }

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                if (idAsignatura.HasValue)
                    comando.Parameters.AddWithValue("@idAsignatura", idAsignatura.Value);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Calificacion
                        {
                            IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Nota1 = reader["nota1"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["nota1"]),
                            Nota2 = reader["nota2"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["nota2"]),
                            Nota3 = reader["nota3"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["nota3"]),
                            Nota4 = reader["nota4"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(reader["nota4"]),
                            NotaFinal = reader["nota_final"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["nota_final"]),
                            FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }


            // obtener todas las calificaciones
            //public List<Calificacion> ObtenerTodos()
            //{
            //    List<Calificacion> lista = new List<Calificacion>();

            //    string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
            //                    c.nota, c.fecha_registro
            //             from calificacion c";

            //    SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

            //    using (SqlDataReader reader = comando.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            lista.Add(new Calificacion
            //            {
            //                IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
            //                IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
            //                IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
            //                Nota = Convert.ToDecimal(reader["nota"]),
            //                FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
            //            });
            //        }
            //    }

            //    conexion.CerrarConexion();
            //    return lista;
            //}
        }


        public class Asistencia
        {
            public int IdAsistencia { get; set; }
            public int IdEstudiante { get; set; }
            public int IdAsignatura { get; set; }
            public DateTime Fecha { get; set; }
            public string Estado { get; set; } // "Presente", "Ausente", "Tarde"

            private cConexion conexion = new cConexion();

            public DataTable ObtenerAsistenciasPorEstudianteYAsignatura(int idEstudiante, int idAsignatura)
            {
                string query = @"
                select id_asistencia, fecha, estado
                from Asistencia
                where id_estudiante = @idEstudiante and id_asignatura = @idAsignatura";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexion.CerrarConexion();
                return dt;
            }

            public bool ModificarAsistencia(int idAsistencia, string nuevoEstado)
            {
                string query = "update Asistencia set estado = @nuevoEstado where id_asistencia = @idAsistencia";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                comando.Parameters.AddWithValue("@idAsistencia", idAsistencia);

                int filas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();

                return filas > 0;
            }



            // obtener asistencia por id
            public Asistencia ObtenerPorId(int id)
            {
                Asistencia asistencia = null;

                string query = @"select a.id_asistencia, a.id_estudiante, a.id_asignatura, 
                                a.fecha, a.estado
                         from asistencia a
                         where a.id_asistencia = @id";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        asistencia = new Asistencia
                        {
                            IdAsistencia = Convert.ToInt32(reader["id_asistencia"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                            Estado = reader["estado"].ToString()
                        };
                    }
                }

                conexion.CerrarConexion();
                return asistencia;
            }

            public List<Asistencia> ObtenerPorEstudianteYAsignatura(int idEstudiante, int? idAsignatura = null)
            {
                List<Asistencia> lista = new List<Asistencia>();

                string query = @"select a.id_asistencia, a.id_estudiante, a.id_asignatura, 
                                a.fecha, a.estado
                         from asistencia a
                         where a.id_estudiante = @idEstudiante";

                if (idAsignatura.HasValue)
                {
                    query += " and a.id_asignatura = @idAsignatura";
                }

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                if (idAsignatura.HasValue)
                    comando.Parameters.AddWithValue("@idAsignatura", idAsignatura.Value);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Asistencia
                        {
                            IdAsistencia = Convert.ToInt32(reader["id_asistencia"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                            Estado = reader["estado"].ToString()
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            // obtener todas las asistencias de un estudiante
            public List<Asistencia> ObtenerPorEstudiante(int idEstudiante)
            {
                List<Asistencia> lista = new List<Asistencia>();

                string query = @"select a.id_asistencia, a.id_estudiante, a.id_asignatura, 
                                a.fecha, a.estado
                         from asistencia a
                         where a.id_estudiante = @idEstudiante";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Asistencia
                        {
                            IdAsistencia = Convert.ToInt32(reader["id_asistencia"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                            Estado = reader["estado"].ToString()
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            // obtener todas las asistencias
            public List<Asistencia> ObtenerTodos()
            {
                List<Asistencia> lista = new List<Asistencia>();

                string query = @"select a.id_asistencia, a.id_estudiante, a.id_asignatura, 
                                a.fecha, a.estado
                         from asistencia a";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Asistencia
                        {
                            IdAsistencia = Convert.ToInt32(reader["id_asistencia"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                            Estado = reader["estado"].ToString()
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            public bool RegistrarAsistencia(Asistencia asistencia)
            {
                string query = @"
                insert into asistencia (id_estudiante, id_asignatura, fecha, estado)
                values (@id_estudiante, @id_asignatura, @fecha, @estado)";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id_estudiante", asistencia.IdEstudiante);
                comando.Parameters.AddWithValue("@id_asignatura", asistencia.IdAsignatura);
                comando.Parameters.AddWithValue("@fecha", asistencia.Fecha);
                comando.Parameters.AddWithValue("@estado", asistencia.Estado);

                int result = comando.ExecuteNonQuery();
                conexion.CerrarConexion();

                return result > 0;
            }
        }


        public class Solicitud
        {
            public int IdSolicitud { get; set; }
            public int IdEstudiante { get; set; }
            public int IdAsignatura { get; set; }
            public string Tipo { get; set; } // "Revision Nota" | "Revision Asistencia"
            public string Descripcion { get; set; }
            public string Estado { get; set; } // "Pendiente" | "Aprobada" | "Rechazada"
            public DateTime Fecha { get; set; }

            private cConexion conexion = new cConexion();


            public DataTable ObtenerSolicitudesPendientes()
            {
                string query = @"
                select id_solicitud, id_estudiante, id_asignatura, tipo, descripcion, estado, fecha
                from Solicitud
                where estado = 'Pendiente'";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conexion.CerrarConexion();
                return dt;
            }

            public void MarcarSolicitud(int idSolicitud, string nuevoEstado)
            {
                string query = @"update Solicitud
                     set estado = @estado
                     where id_solicitud = @idSolicitud";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@estado", nuevoEstado);
                comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);

                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }



            // obtener solicitud por id
            public Solicitud ObtenerPorId(int id)
            {
                Solicitud solicitud = null;

                string query = @"select s.id_solicitud, s.id_estudiante, s.id_asignatura, 
                                s.tipo, s.descripcion, s.estado, s.fecha
                         from solicitud s
                         where s.id_solicitud = @id";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        solicitud = new Solicitud
                        {
                            IdSolicitud = Convert.ToInt32(reader["id_solicitud"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Tipo = reader["tipo"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            Estado = reader["estado"].ToString(),
                            Fecha = Convert.ToDateTime(reader["fecha"])
                        };
                    }
                }

                conexion.CerrarConexion();
                return solicitud;
            }

            // obtener todas las solicitudes de un estudiante
            public List<Solicitud> ObtenerPorEstudiante(int idEstudiante)
            {
                List<Solicitud> lista = new List<Solicitud>();

                string query = @"select s.id_solicitud, s.id_estudiante, s.id_asignatura, 
                                s.tipo, s.descripcion, s.estado, s.fecha
                         from solicitud s
                         where s.id_estudiante = @idEstudiante";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Solicitud
                        {
                            IdSolicitud = Convert.ToInt32(reader["id_solicitud"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Tipo = reader["tipo"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            Estado = reader["estado"].ToString(),
                            Fecha = Convert.ToDateTime(reader["fecha"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            // obtener todas las solicitudes
            public List<Solicitud> ObtenerTodos()
            {
                List<Solicitud> lista = new List<Solicitud>();

                string query = @"select s.id_solicitud, s.id_estudiante, s.id_asignatura, 
                                s.tipo, s.descripcion, s.estado, s.fecha from solicitud s";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Solicitud
                        {
                            IdSolicitud = Convert.ToInt32(reader["id_solicitud"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Tipo = reader["tipo"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            Estado = reader["estado"].ToString(),
                            Fecha = Convert.ToDateTime(reader["fecha"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

        }

        public class Profesor
        {   
            cConexion conexion = new cConexion();
            public int IdProfesor { get; set; }
            public int IdUsuario { get; set; }
            public string Especialidad { get; set; }

            public Profesor(int idProfesor)
            {
                IdProfesor = idProfesor;
            }
            public Profesor()
            {
            }

            public DataTable ObtenerAsignaturas()
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = @"
                select id_asignatura, nombre
                from asignatura
                where id_profesor = @idProfesor";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
                    {
                        cmd.Parameters.AddWithValue("@idProfesor", this.IdProfesor);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("error al obtener asignaturas: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
                return dt;
            }



        }




    }

}

