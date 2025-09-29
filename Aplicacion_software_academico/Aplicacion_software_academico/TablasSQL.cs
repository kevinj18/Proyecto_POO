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

            public string validarUsuario(string correo, string contraseña)
            {
                SqlCommand comando = new SqlCommand("select count(*) from Usuario WHERE correo = @correo", conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@correo", correo);


                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Contraseña = reader["contrasena"].ToString();
                        if (Contraseña == contraseña)
                        {
                            string rol = reader["rol"] as string ?? "estudiante";
                            MessageBox.Show("Inicio de sesión correcto. Rol: " + rol);
                            return "Correcto";
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
    }

}

