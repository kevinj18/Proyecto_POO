using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            // Valida si el usuario existe en la base de datos
            public string validarUsuario(string correo, string contraseña)
            {
                SqlCommand comando = new SqlCommand("select contrasena, rol from usuario where correo = @correo", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@correo", correo);


                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Contraseña = reader["contrasena"].ToString();
                        if (Contraseña == contraseña)
                        {
                            string rol = reader["rol"].ToString();

                            // Guardar la sesión
                            SesionActual.Correo = correo;
                            SesionActual.Rol = rol;

                            if (rol == "estudiante" && reader["id_estudiante"] != DBNull.Value)
                            {
                                SesionActual.IdEstudiante = Convert.ToInt32(reader["id_estudiante"]);
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
            public string registrarUsuario(string nombre, string correo, string contraseña, string rol)
            {
                try
                {
                    cmd = new SqlCommand("select * from Usuario where correo = @correo", conexion.AbrirConexion());

                    cmd.Parameters.AddWithValue("@correo", correo);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return "Este correo ya esta registrado.";
                    }

                    SqlCommand comando = new SqlCommand("INSERT INTO Usuario (nombre, correo, contrasena, rol) VALUES (@nombre, @correo, @contrasena ,@rol)", conexion.AbrirConexion());
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@rol", rol);
                    comando.ExecuteNonQuery();
                    return "Usuario registrado correctamente";

                }
                catch
                {
                    return "Error al registrar Usuario";
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
            public decimal Nota { get; set; }
            public DateTime FechaRegistro { get; set; }

            private cConexion conexion = new cConexion();

            // obtener calificación por id
            public Calificacion ObtenerPorId(int id)
            {
                Calificacion calificacion = null;

                string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
                                c.nota, c.fecha_registro
                         from calificacion c
                         where c.id_calificacion = @id";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calificacion = new Calificacion
                        {
                            IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Nota = Convert.ToDecimal(reader["nota"]),
                            FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
                        };
                    }
                }

                conexion.CerrarConexion();
                return calificacion;
            }

            // obtener todas las calificaciones de un estudiante
            public List<Calificacion> ObtenerPorEstudiante(int idEstudiante)
            {
                List<Calificacion> lista = new List<Calificacion>();

                string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
                                c.nota, c.fecha_registro
                         from calificacion c
                         where c.id_estudiante = @idEstudiante";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Calificacion
                        {
                            IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Nota = Convert.ToDecimal(reader["nota"]),
                            FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            public List<Calificacion> ObtenerPorEstudianteYAsignatura(int idEstudiante, int? idAsignatura = null)
            {
                List<Calificacion> lista = new List<Calificacion>();

                string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
                            c.nota, c.fecha_registro
                     from calificacion c
                     where c.id_estudiante = @idEstudiante";

                if (idAsignatura.HasValue)
                {
                    query += " and c.id_asignatura = @idAsignatura";
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
                            Nota = Convert.ToDecimal(reader["nota"]),
                            FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }

            // obtener todas las calificaciones
            public List<Calificacion> ObtenerTodos()
            {
                List<Calificacion> lista = new List<Calificacion>();

                string query = @"select c.id_calificacion, c.id_estudiante, c.id_asignatura, 
                                c.nota, c.fecha_registro
                         from calificacion c";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Calificacion
                        {
                            IdCalificacion = Convert.ToInt32(reader["id_calificacion"]),
                            IdEstudiante = Convert.ToInt32(reader["id_estudiante"]),
                            IdAsignatura = Convert.ToInt32(reader["id_asignatura"]),
                            Nota = Convert.ToDecimal(reader["nota"]),
                            FechaRegistro = Convert.ToDateTime(reader["fecha_registro"])
                        });
                    }
                }

                conexion.CerrarConexion();
                return lista;
            }
        }


        public class Asistencia
        {
            public int IdAsistencia { get; set; }
            public int IdEstudiante { get; set; }
            public int IdAsignatura { get; set; }
            public DateTime Fecha { get; set; }
            public string Estado { get; set; } // "Presente", "Ausente", "Tarde"

            private cConexion conexion = new cConexion();

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
    


    }

}

